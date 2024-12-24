using Mate.Entities.Abstract;

namespace Mate.Entities.Concrete
{
    public class OrderSituation : BaseEntity
    {
        public string Situation { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
