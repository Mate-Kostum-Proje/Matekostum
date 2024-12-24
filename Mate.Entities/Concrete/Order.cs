using Mate.Entities.Abstract;

namespace Mate.Entities.Concrete
{
    public class Order : BaseEntity
    {


        public UserInfo UserInfos { get; set; }
        public string UserId { get; set; }


        public List<OrderDetail> OrderDetails { get; set; }


    }
}
