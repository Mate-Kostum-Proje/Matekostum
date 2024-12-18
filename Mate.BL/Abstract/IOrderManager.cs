using Mate.Entities.Concrete;

namespace Mate.BL.Abstract
{
    public interface IOrderManager : IManager<Order>
    {
        public bool CanPlaceOrder(string userId, List<OrderDetail> orderDetails, List<ProductSize> productSizes);
        public bool PlaceOrder(string userId, List<OrderDetail> orderDetails, List<ProductSize> productSizes);
        public void Update(Product product);
    }
}
