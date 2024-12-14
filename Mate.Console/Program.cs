using Mate.BL.Concrete;
using Mate.Entities.Concrete;

namespace Mate.Console
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			AddRoleForUser();

		}
		public static void AddRoleForUser()
		{
			Manager<UserInfo> userManager = new Manager<UserInfo>();
			Manager<Role> roleManager = new Manager<Role>();
			//aliye admin hakki verme
			var firstadmin = userManager.GetAllInclude(p => p.Email == "idilerdogan@sabanciuniv.edu", p => p.Roles).FirstOrDefault();
			var Admin = roleManager.GetById("Admin", p => p.Users).FirstOrDefault();


			firstadmin.Roles.Add(Admin);
			roleManager.Update(Admin);
			Admin.Users.Add(firstadmin);
			userManager.Update(firstadmin);

		}
	}
}
