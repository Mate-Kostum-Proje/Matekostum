using Mate.Entities.Concrete;

namespace Mate.BL.Abstract
{
    public interface IBasketManager : IManager<Basket>
    {
        public void AddToBasket(string userId, BasketDetail basketDetail, ProductSize productSize);
        public decimal CalculateTotalPrice(string userId);
        public void RemoveFromBasket(string basketDetailId);
        public void ClearBasket(string userId);
        public List<BasketDetail> GetBasketDetails(string userId);
    }
}
