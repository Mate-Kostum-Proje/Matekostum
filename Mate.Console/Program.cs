using Mate.DAL.DbContexts;
using Microsoft.EntityFrameworkCore;
namespace Mate.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AddRoleForUser();
            #region DbContext ile
            SqlDbContext context = new SqlDbContext();
            #region Var olan bir kullaniciya var olan bir role atama

            var idil = context.UserInfos.Include(p => p.Roles).FirstOrDefault();

            var admin = context.Roles.FirstOrDefault(p => p.RoleName == "Admin");
            idil.Roles.Add(new Entities.Concrete.UsersRoles { Role = admin });
            context.SaveChanges();
            #endregion

            #region yeni kullanici ,yeni bir role olusturma
            //Role calisanRole = new Role() { RoleName = "Calisan", CreatedAt = DateTime.Now };
            //var ercan = new UserInfo
            //{
            //	Name = "Ercan",
            //	Email = "qwe@gmail.com",
            //	GSM = "53211122233",
            //	TcNo = "32112312311",
            //	SurName = "Ozturk",
            //	City = "Istanbul",
            //	Address = "Kadikoy",
            //	District = "Kadikoy",
            //	Password = "qweasd"

            //};
            //ercan.Roles.Add(new UsersRoles { Role = calisanRole });
            //context.UserInfos.Add(ercan);
            //context.SaveChanges();
            #endregion
            #region Role cikartma
            //var idil = context.UserInfos.Include(p => p.Roles).ThenInclude(p => p.Role).FirstOrDefault();

            //var user = context.Roles.FirstOrDefault(p => p.RoleName == "User");
            //idil.Roles.Remove(new Entities.Concrete.UsersRoles { Role = user });
            //var silinecekRole = idil.Roles.FirstOrDefault(p => p.RoleId == "9ddd0484-6af2-4681-a780-ea267785be25");
            //var silinecekRole = idil.Roles.FirstOrDefault(p => p.Role.RoleName == "Admin");

            //idil.Roles.Remove(silinecekRole);
            //context.SaveChanges();
            #endregion
            #endregion


            #region Generic Repositoruy ile Deneme
            //Repository<UserInfo> userRepository = new Repository<UserInfo>();
            //Repository<Role> roleRepository = new Repository<Role>();

            //var idil = userRepository.GetAllInclude(p => p.Name == "Idil").FirstOrDefault();
            //var adminRole = roleRepository.Get(p => p.RoleName == "Admin");

            //idil.Roles.Add(new UsersRoles { CreatedAt = DateTime.Now, Role = adminRole });

            #endregion
            //Console.WriteLine("Kullanıcı bulunamadı.");
        }
        public static void AddRoleForUser()
        {
            //Manager<UserInfo> userManager = new Manager<UserInfo>();
            //Manager<Role> roleManager = new Manager<Role>();
            ////aliye admin hakki verme
            //var idil = userManager.GetAllInclude(p => p.Name == "idil", p => p.Roles).FirstOrDefault();

            //var admin = roleManager.Get(p => p.RoleName == "Admin");

            //idil.Roles.Add(admin);
            //userManager.Update(idil);
            //userManager._dbContext.SaveChanges();

        }
        public static void AddRoleForUser2()
        {
            //try
            //{
            //	IManager<UserInfo> userManager = new Manager<UserInfo>();
            //	IManager<Role> roleManager = new Manager<Role>();

            //	// Kullanıcı ve rol nesneleri alınır
            //	var idil = userManager.GetAllInclude(p => p.Name == "idil", p => p.Roles).FirstOrDefault();
            //	if (idil == null)
            //	{
            //		Console.WriteLine("Kullanıcı bulunamadı.");
            //		return;
            //	}

            //	var admin = roleManager.Get(p => p.RoleName == "Admin");
            //	if (admin == null)
            //	{
            //		Console.WriteLine("Rol bulunamadı.");
            //		return;
            //	}

            //	// Eğer kullanıcıda bu rol yoksa ekle
            //	if (!idil.Roles.Contains(admin))
            //	{
            //		idil.Roles.Add(admin);
            //		admin.Users.Add(idil);
            //		userManager.Update(idil);

            //		Console.WriteLine("Admin rolü başarıyla kullanıcılara eklendi.");
            //	}
            //	else
            //	{
            //		Console.WriteLine("Kullanıcıda zaten bu rol mevcut.");
            //	}
            //}
            //catch (Exception ex)
            //{
            //	// Hata durumunda bir log veya hata mesajı gösterebiliriz
            //	Console.WriteLine("Hata: " + ex.Message);
            //}
        }


    }

}