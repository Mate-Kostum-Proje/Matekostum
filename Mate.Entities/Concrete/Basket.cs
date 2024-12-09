using Mate.Entities.Abstract;

namespace Mate.Entities.Concrete
{
    public class Basket : BaseEntity //TODO??
    {


        public UserInfo UserInfos { get; set; }
        public string UserId { get; set; }
        public List<BasketDetail> BasketDetails { get; set; }
    }
}
