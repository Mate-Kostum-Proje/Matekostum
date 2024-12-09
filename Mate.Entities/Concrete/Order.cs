using Mate.Entities.Abstract;

namespace Mate.Entities.Concrete
{
    public class Order : BaseEntity
    {


        public UserInfo UserInfos { get; set; }
        public string UserId { get; set; }
        public OrderSituation? OrderSituations { get; set; }
        public string? SituationName { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }


    }
}
