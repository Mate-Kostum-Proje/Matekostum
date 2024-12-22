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
            IManager<Size> sizeRepository,
            IManager<OrderSituation> orderSituationRepository,
            SqlDbContext sqlDbContext) : Manager<Order>, IOrderManager
    {

        private new readonly SqlDbContext _dbContext = sqlDbContext;
        private readonly IManager<Order> _orderRepository = orderRepository;
        private readonly IManager<OrderDetail> _orderDetailRepository = orderDetailRepository;
        private readonly IManager<OrderSituation> _orderSituationRepository = orderSituationRepository;

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


        public bool PlaceOrder(string userId, List<OrderDetail> orderDetails, List<ProductSize> productSizes, List<Product> products)
        {

            //var basketDetails = basketRepository.GetAllInclude(p => p.UserId == userId).FirstOrDefault().BasketDetails;

            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                var basketDetails = basketDetailRepository.GetAllInclude(p => p.Baskets.UserId == userId);
                try
                {
                    // Stok kontrolü
                    ValidateOrder(orderDetails, productSizes);
                    var situationName = orderSituationRepository.GetAll().Where(p => p.Situation == "Siparişiniz Alındı").FirstOrDefault();

                    // Yeni bir sipariş oluştur
                    var order = new Order
                    {
                        UserId = userId,
                        CreatedAt = DateTime.Now,
                        SituationId = situationName.Id
                    };
                    _orderRepository.Create(order);

                    // Sipariş detaylarını işleme al
                    foreach (var basketDetail in basketDetails)
                    {

                        var product = _productRepository.GetById(basketDetail.ProductId);
                        var productSize = productSizeRepository.Get(p => p.ProductId == p.Products.Id && p.Sizes.SizeNumber == basketDetail.ProductSize);
                        //var productSize = productSizes.FirstOrDefault(p => p.ProductId == basketDetail.ProductId && p.Sizes.SizeNumber == basketDetail.ProductSize);
                        //var productSize = productSizes.FirstOrDefault(ps => ps.ProductId == basketDetail.ProductId && ps.Sizes.SizeNumber == basketDetail.ProductSize);

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
                            CreatedAt = DateTime.Now

                        };


                        // OrderDetail'ı veritabanına kaydet
                        _orderDetailRepository.Create(orderDetail);

                        _basketDetailRepository.Delete(basketDetail);


                    }


                    // Sepeti temizleme işlemi
                    //var basket = _basketRepository.GetAll().FirstOrDefault(p => p.UserId == userId);
                    //if (basket != null)
                    //{
                    //    foreach (var orderDetail in orderDetails)
                    //    {
                    //        var basketDetail = _basketDetailRepository.GetAll()
                    //            .FirstOrDefault(p => p.BasketId == basket.Id && p.ProductId == orderDetail.ProductId);

                    //        if (basketDetail != null)
                    //        {
                    //            _basketDetailRepository.Delete(basketDetail);
                    //        }
                    //    }
                    //}
                    transaction.Commit();
                    return true;
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
        public List<Order> GetAllOrders()
        {
            return _orderRepository.GetAll().ToList();
        }

        public List<OrderDetail> GetOrderDetails(string userId)
        {
            var order = _orderRepository.GetAll().FirstOrDefault(p => p.UserId == userId);

            if (order == null)
                return new List<OrderDetail>();

            return _orderDetailRepository.GetAll().Where(p => p.OrderId == order.Id).ToList();
        }
    }
}
