using Mate.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mate.Entities.Concrete
{
    public class UsersRoles :BaseEntity
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }

        public Role Role { get; set; }
        public UserInfo UserInfo { get; set; }
    }
}
