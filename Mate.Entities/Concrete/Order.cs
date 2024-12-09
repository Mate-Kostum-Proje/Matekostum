using Mate.Entities.Abstract;

namespace Mate.Entities.Concrete
{
    public class Order : BaseEntity
    {

        public int ProductSize { get; set; }
        public int Amount { get; set; }
        public bool IsSale { get; set; }
        public UserInfo UserInfo { get; set; }
        public OrderSituation OrderSituation { get; set; }
        public List<Product> Product { get; set; }

    }
}
