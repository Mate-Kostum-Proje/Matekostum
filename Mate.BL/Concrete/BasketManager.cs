using Mate.BL.Abstract;
using Mate.Entities.Concrete;

namespace Mate.BL.Concrete
{
    public class BasketManager(IManager<Basket> basketRepository,
            IManager<BasketDetail> basketDetailRepository,
            IManager<Product> productRepository,
            IManager<ProductSize> productSizeRepository) : Manager<Basket>, IBasketManager
    {
        private readonly IManager<Basket> _basketRepository = basketRepository;
        private readonly IManager<BasketDetail> _basketDetailRepository = basketDetailRepository;
        private readonly IManager<Product> _productRepository = productRepository;
        private IManager<ProductSize> _productSizeRepository = productSizeRepository;



        public void AddToBasket(string userId, BasketDetail basketDetail, ProductSize productSize)
        {
            // Kullanıcının mevcut sepetini bul
            var basket = _basketRepository.GetAll().FirstOrDefault(p => p.UserId == userId);

            if (basket == null)
            {
                // Eğer sepet yoksa yeni bir tane oluştur
                basket = new Basket { UserId = userId };
                _basketRepository.Create(basket);
            }

            // Sepetteki mevcut ürünü kontrol et
            var existingBasketDetail = _basketDetailRepository.GetAll()
                .FirstOrDefault(p => p.BasketId == basket.Id && p.ProductId == basketDetail.ProductId);

            // Ürün stok kontrolü
            var product = _productRepository.GetById(basketDetail.ProductId);
            if (product == null)
            {
                throw new InvalidOperationException($"Ürün bulunamadı: {basketDetail.ProductId}");
            }

            int currentBasketAmount = existingBasketDetail?.Amount ?? 0; // Sepetteki mevcut ürün miktarı \sepet boş olabilir \sayı bilinmiyor
            int totalRequestedAmount = currentBasketAmount + basketDetail.Amount; // Sepet ve ekleme toplamı

            if (totalRequestedAmount > productSize.SizeAmount)
            {
                throw new InvalidOperationException($"Stok yetersiz: {product.ProductName}. Maksimum eklenebilir miktar: {productSize.SizeAmount - currentBasketAmount}");
            }

            if (existingBasketDetail == null)
            {
                // Ürün sepette yoksa yeni bir detay oluştur
                basketDetail.BasketId = basket.Id;
                _basketDetailRepository.Create(basketDetail);
            }
            else
            {
                // Ürün sepette zaten varsa miktarı güncelle
                existingBasketDetail.Amount += basketDetail.Amount;
                _basketDetailRepository.Update(existingBasketDetail);
            }
        }

        // Sepetten ürün silme
        public void RemoveFromBasket(string basketDetailId)
        {

            var basketDetail = _basketDetailRepository.GetById(basketDetailId);

            if (basketDetail == null)
                throw new InvalidOperationException("Sepet detayı bulunamadı.");

            _basketDetailRepository.Delete(basketDetail);
        }

        // Kullanıcının tüm sepetini temizleme
        public void ClearBasket(string userId)
        {
            var basket = _basketRepository.GetAll().FirstOrDefault(p => p.UserId == userId);

            if (basket == null)
                return;

            var basketDetails = _basketDetailRepository.GetAll().Where(p => p.BasketId == basket.Id).ToList();

            foreach (var detail in basketDetails)
            {
                _basketDetailRepository.Delete(detail);
            }

            _basketRepository.Delete(basket);
        }
        public List<BasketDetail> GetBasketDetails(string userId)
        {
            var basket = _basketRepository.GetAll().FirstOrDefault(p => p.UserId == userId);

            if (basket == null)
                return new List<BasketDetail>();

            return _basketDetailRepository.GetAll().Where(p => p.BasketId == basket.Id).ToList();
        }
    }
}
