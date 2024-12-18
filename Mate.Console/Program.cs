using Mate.BL.Abstract;
using Mate.BL.Concrete;
using Mate.Entities.Concrete;
namespace Mate.ConsoleApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			AddRoleForUser();
			//Console.WriteLine("Kullanıcı bulunamadı.");
		}
		public static void AddRoleForUser()
		{
			Manager<UserInfo> userManager = new Manager<UserInfo>();
			Manager<Role> roleManager = new Manager<Role>();
			//aliye admin hakki verme
			var ali = userManager.GetAllInclude(p => p.Name == "idil", p => p.Roles).FirstOrDefault();

			var admin = roleManager.Get(p => p.RoleName == "Admin");
			ali.Roles.Clear();
			ali.Roles.Add(admin);
			userManager._dbContext.UserInfos.Update(ali);
			userManager._dbContext.SaveChanges();

		}
		public static void AddRoleForUser2()
		{
			try
			{
				IManager<UserInfo> userManager = new Manager<UserInfo>();
				IManager<Role> roleManager = new Manager<Role>();

				// Kullanıcı ve rol nesneleri alınır
				var idil = userManager.GetAllInclude(p => p.Name == "idil", p => p.Roles).FirstOrDefault();
				if (idil == null)
				{
					Console.WriteLine("Kullanıcı bulunamadı.");
					return;
				}

				var admin = roleManager.Get(p => p.RoleName == "Admin");
				if (admin == null)
				{
					Console.WriteLine("Rol bulunamadı.");
					return;
				}

				// Eğer kullanıcıda bu rol yoksa ekle
				if (!idil.Roles.Contains(admin))
				{
					idil.Roles.Add(admin);
					admin.Users.Add(idil);
					userManager.Update(idil);

					Console.WriteLine("Admin rolü başarıyla kullanıcılara eklendi.");
				}
				else
				{
					Console.WriteLine("Kullanıcıda zaten bu rol mevcut.");
				}
			}
			catch (Exception ex)
			{
				// Hata durumunda bir log veya hata mesajı gösterebiliriz
				Console.WriteLine("Hata: " + ex.Message);
			}
		}


	}

}
