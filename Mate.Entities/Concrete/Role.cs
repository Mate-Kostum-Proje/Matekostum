using Mate.Entities.Abstract;

namespace Mate.Entities.Concrete
{
    public class Role : BaseEntity
    {
        public string RoleName { get; set; }
        public List<UserInfo> Users { get; set; }
    }
}
