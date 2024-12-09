using Mate.Entities.Abstract;

namespace Mate.Entities.Concrete
{
    public class Basket : BaseEntity //TODO??
    {
        public Product Product { get; set; }

        public UserInfo UserInfo { get; set; }

        public string ProductId { get; set; }
        public int ProductSize { get; set; }
        public string UserId { get; set; }

        public int Amount { get; set; }
    }
}
