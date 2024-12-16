using Mate.BL.Concrete;
using Mate.Entities.Concrete;

namespace Mate.Console
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
			try
			{
				Manager<UserInfo> userManager = new Manager<UserInfo>();
				Manager<Role> roleManager = new Manager<Role>();

				// Kullanıcı ve rol nesneleri alınır
				var ali = userManager.GetAllInclude(p => p.Name == "ali", p => p.Roles).FirstOrDefault();
				if (ali == null)
				{
					//Console.WriteLine("Kullanıcı bulunamadı.");
					return;
				}

				var admin = roleManager.Get(p => p.RoleName == "admin");
				if (admin == null)
				{
					//Console.WriteLine("Rol bulunamadı.");
					return;
				}

				// Eğer kullanıcıda bu rol yoksa ekle
				if (!ali.Roles.Contains(admin))
				{
					ali.Roles.Add(admin);
					userManager.Update(ali);
					//Console.WriteLine("Admin rolü başarıyla kullanıcılara eklendi.");
				}
				else
				{
					//Console.WriteLine("Kullanıcıda zaten bu rol mevcut.");
				}
			}
			catch (Exception ex)
			{
				// Hata durumunda bir log veya hata mesajı gösterebiliriz
				//Console.WriteLine("Hata: " + ex.Message);
			}
		}


	}

}
