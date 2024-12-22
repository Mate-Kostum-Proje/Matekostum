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
            IManager<Product> productRepository,
            IManager<ProductSize> productSizeRepository,
            IManager<Size> sizeRepository) : Manager<Order>, IOrderManager
    {

        private readonly SqlDbContext _dbContext;
        private readonly IManager<Order> _orderRepository = orderRepository;
        private readonly IManager<OrderDetail> _orderDetailRepository = orderDetailRepository;
        private readonly IManager<Basket> _basketRepository = basketRepository;
        private readonly IManager<BasketDetail> _basketDetailRepository = basketDetailRepository;
        private readonly IManager<Product> _productRepository = productRepository;
        private readonly IManager<ProductSize> _productSizeRepository = productSizeRepository;
        private readonly IManager<Size> _sizeRepository = sizeRepository;


        private void ValidateOrder(List<OrderDetail> orderDetails, List<ProductSize> productSizes)
        {
            foreach (var orderDetail in orderDetails)
            {
                var productSize = productSizes
                    .FirstOrDefault(ps => ps.ProductId == orderDetail.ProductId && ps.Sizes.SizeNumber == orderDetail.ProductSize);

                if (productSize == null)
                {
                    throw new InvalidOperationException($"Ürün bedeni bulunamadı: Ürün Adı={orderDetail.Products.ProductName}, Beden={orderDetail.ProductSize}");
                }

                if (orderDetail.Amount > productSize.SizeAmount)
                {
                    throw new InvalidOperationException($"Yetersiz stok: Ürün Adı={orderDetail.Products.ProductName}");
                }
            }
        }

        public bool CanPlaceOrder(string userId, List<OrderDetail> orderDetails, List<ProductSize> productSizes)
        {
            try
            {
                ValidateOrder(orderDetails, productSizes);
                return true;
            }
            catch (InvalidOperationException)
            {
                return false;
            }
        }


        public bool PlaceOrder(string userId, List<OrderDetail> orderDetails, List<ProductSize> productSizes, List<Product> products, List<BasketDetail> basketDetails)
        {



            try
            {
                // Stok kontrolü
                ValidateOrder(orderDetails, productSizes);

                // Yeni bir sipariş oluştur
                var order = new Order
                {
                    UserId = userId,
                    CreatedAt = DateTime.Now,

                };
                _orderRepository.Create(order);

                // Sipariş detaylarını işleme al
                foreach (var basketDetail in basketDetails)
                {

                    var product = _productRepository.GetById(basketDetail.ProductId);

                    var productSize = productSizes
                        .FirstOrDefault(ps => ps.ProductId == basketDetail.ProductId && ps.Sizes.SizeNumber == basketDetail.ProductSize);

                    // ProductSize'ın miktarını güncelle
                    productSize.SizeAmount -= basketDetail.Amount;
                    _productSizeRepository.Update(productSize);

                    // OrderDetail oluştur
                    var orderDetail = new OrderDetail
                    {
                        OrderId = order.Id,  // Siparişin ID'sini ata
                        ProductId = basketDetail.ProductId,
                        ProductSize = basketDetail.ProductSize,
                        Amount = basketDetail.Amount,
                        UnitPiceForRent = product.UnitPriceForRent, // Kiralama fiyatı
                        UnitPriceForSale = product.UnitPriceForSale, // Satış fiyatı

                    };

                    // OrderDetail'ı veritabanına kaydet
                    _orderDetailRepository.Create(orderDetail);
                }


                // Sepeti temizleme işlemi
                var basket = _basketRepository.GetAll().FirstOrDefault(p => p.UserId == userId);
                if (basket != null)
                {
                    foreach (var orderDetail in orderDetails)
                    {
                        var basketDetail = _basketDetailRepository.GetAll()
                            .FirstOrDefault(p => p.BasketId == basket.Id && p.ProductId == orderDetail.ProductId);

                        if (basketDetail != null)
                        {
                            _basketDetailRepository.Delete(basketDetail);
                        }
                    }
                }


                return true;
            }
            catch (Exception ex)
            {

                throw new InvalidOperationException("Sipariş sırasında bir hata oluştu.", ex);
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
        public List<Order> GetAllOrders()
        {
            return _orderRepository.GetAll().ToList();
        }

        public List<OrderDetail> GetOrderDetails(string orderId)
        {
            return _orderDetailRepository.GetAll()
                .Where(od => od.OrderId == orderId)
                .ToList();
        }
    }
}
