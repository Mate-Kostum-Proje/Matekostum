using Mate.Entities.Abstract;
namespace Mate.Entities.Concrete
{
	public class UsersRoles : BaseEntity
	{
		public string UserId { get; set; }
		public string RoleId { get; set; }
		public Role Role { get; set; }
		public UserInfo UserInfo { get; set; }
	}
}