using Mate.Entities.Abstract;

namespace Mate.Entities.Concrete
{
    public class Order : BaseEntity
    {

        public int ProductSize { get; set; }
        public int Amount { get; set; }
        public bool IsSale { get; set; }
        public List<Product> Product { get; set; }
        public List<UserInfo> UserInfo { get; set; }
        public List<OrderSituation> OrderSituation { get; set; }


    }
}
