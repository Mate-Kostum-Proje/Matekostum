using Mate.Entities.Abstract;

namespace Mate.Entities.Concrete
{
    public class Basket : BaseEntity
    {


        public UserInfo UserInfos { get; set; }
        public string UserId { get; set; }
        public List<BasketDetail> BasketDetails { get; set; }
    }
}
