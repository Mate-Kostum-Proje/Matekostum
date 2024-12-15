using Mate.Entities.Concrete;

namespace Mate.BL.Abstract
{
	public interface IOrderManager : IManager<Order>
	{
		public bool CanPlaceOrder(string userId, List<OrderDetail> orderDetails);
		public bool PlaceOrder(string userId, List<OrderDetail> orderDetails);
		public void Update(Product product);
	}
}
