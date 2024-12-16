using Mate.BL.Abstract;
using Mate.DAL.DbContexts;
using Mate.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Mate.BL.Concrete
{
    public class OrderManager(
            IManager<Order> orderRepository,
            IManager<OrderDetail> orderDetailRepository,
            IManager<Basket> basketRepository,
            IManager<BasketDetail> basketDetailRepository,
            IManager<Product> productRepository) : Manager<Order>, IOrderManager
    {

        private readonly SqlDbContext _dbContext;
        private readonly IManager<Order> _orderRepository = orderRepository;
        private readonly IManager<OrderDetail> _orderDetailRepository = orderDetailRepository;
        private readonly IManager<Basket> _basketRepository = basketRepository;
        private readonly IManager<BasketDetail> _basketDetailRepository = basketDetailRepository;
        private readonly IManager<Product> _productRepository = productRepository;

        public bool CanPlaceOrder(string userId, List<OrderDetail> orderDetails) //Aşağıda aslında buna bakıyorum ama ayrı bi metod olarak kalsın
        {
            foreach (var orderDetail in orderDetails)
            {
                var product = _productRepository.GetById(orderDetail.ProductId);
                if (product == null)
                {
                    throw new InvalidOperationException($"Ürün bulunamadı: {product.ProductName}");
                }

                // Sipariş miktarı stoktan fazla mı kontrol et
                if (orderDetail.Amount > product.Amount)
                {
                    throw new InvalidOperationException($"Yetersiz stok: {product.ProductName}");
                }
            }

            return true;
        }

        public bool PlaceOrder(string userId, List<OrderDetail> orderDetails)
        {
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    // Sipariş verilebilirlik kontrolü
                    if (!CanPlaceOrder(userId, orderDetails))
                    {
                        throw new InvalidOperationException("Stok yetersiz, sipariş verilemez.");
                    }

                    // Yeni bir sipariş oluştur
                    var order = new Order
                    {
                        UserId = userId,
                        CreatedAt = DateTime.Now,
                    };
                    _orderRepository.Create(order);

                    // Sipariş detaylarını işleme al
                    foreach (var orderDetail in orderDetails)
                    {
                        var product = _productRepository.GetById(orderDetail.ProductId);
                        if (product == null)
                        {
                            throw new InvalidOperationException($"Ürün bulunamadı: {orderDetail.ProductId}");
                        }

                        // Stok güncellemesi
                        if (orderDetail.Amount > product.Amount)
                        {
                            throw new InvalidOperationException($"Yetersiz stok: {product.ProductName}");
                        }

                        product.Amount -= orderDetail.Amount;
                        _productRepository.Update(product);

                        // Sipariş detayını siparişe ekle
                        orderDetail.OrderId = order.Id;
                        _orderDetailRepository.Create(orderDetail);
                    }

                    // Kullanıcının sepetini bul
                    var basket = _basketRepository.GetAll()
                        .FirstOrDefault(p => p.UserId == userId);

                    if (basket == null)
                    {
                        throw new InvalidOperationException("Sepet bulunamadı.");
                    }

                    // Sepetteki ürünleri kontrol et ve sipariş edilen ürünleri sil
                    foreach (var orderDetail in orderDetails)
                    {
                        // Sepetteki ürünleri, sepetId ve productId ile eşleştir
                        var basketDetail = _basketDetailRepository.GetAll()
                            .FirstOrDefault(p => p.BasketId == basket.Id && p.ProductId == orderDetail.ProductId);

                        if (basketDetail != null)
                        {
                            // Sipariş edilen ürün sepetteyse, sepetteki ürünü sil
                            _basketDetailRepository.Delete(basketDetail);
                        }
                    }

                    // İşlemleri commit et
                    transaction.Commit();
                    return true;
                }
                catch (DbUpdateConcurrencyException)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Stok başka bir işlem tarafından güncellendi.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Sipariş sırasında bir hata oluştu.", ex);
                }
            }
        }

        public void Update(Product product)
        {
            try
            {
                _dbContext.Products.Attach(product);
                _dbContext.Entry(product).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new InvalidOperationException("Concurrency hatası: Ürün başka bir işlem tarafından güncellendi.", ex);
            }
        }

    }
}
