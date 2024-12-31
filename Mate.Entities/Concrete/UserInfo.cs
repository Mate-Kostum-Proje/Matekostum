using Mate.Entities.Abstract;

namespace Mate.Entities.Concrete
{
    public class UserInfo : BaseEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string TcNo { get; set; }
        public string Email { get; set; }
        public string GSM { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public List<UsersRoles>? Roles { get; set; } = new List<UsersRoles>();
        public List<Order>? OrderList { get; set; }
        public List<Basket>? BasketList { get; set; }
    }
}
