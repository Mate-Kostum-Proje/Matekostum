using System.Security.Claims;
using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Mate.BL.Abstract;
using Mate.DAL.DbContexts;
using Mate.Entities.Concrete;
using Mate.MVC.Models.VMs;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Mate.MVC.Controllers
{
	[Authorize]
	public class AccountController(IManager<Role> roleManager, INotyfService notyfService, IManager<UserInfo> userManager, IMapper mapper, SqlDbContext sqlDbContext) : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Users()
		{
			var users = userManager.GetAllInclude(null, p => p.Roles).ToList();
			return View(users);
		}
		[HttpGet]
		[AllowAnonymous] // Burasi Herkese açik hale gelir
		public IActionResult Login()
		{
			LoginVM loginVM = new LoginVM();
			return View(loginVM);
		}
		[HttpPost]
		[AllowAnonymous]
		//public IActionResult Login(string email,string password,bool rememberme)
		public async Task<IActionResult> Login(LoginVM loginVM)
		{
			var user = userManager.GetAllInclude(p => p.Email == loginVM.Email && p.Password == loginVM.Password
			, p => p.Roles).FirstOrDefault();
			if (user == null)
			{
				notyfService.Error("Email yada Password hatalı");
				return View(loginVM);
			}

			// Cookie uzerinde tutulacak bilgileri tanimliyoruz. Yani Kimlik karti uzerindeki bilgiler gibi dusunebilirsiniz.
			string roles = "";
			foreach (var item in user.Roles)
			{
				roles += item.RoleName + " ";
			}
			var claims = new List<Claim>
			{
				new Claim(ClaimTypes.NameIdentifier, loginVM.Email),
				new Claim(ClaimTypes.Role,roles)
                //new Claim(ClaimTypes.UserData,user.PhotoPath)

            };
			var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
			var authenticationProperty = new AuthenticationProperties()
			{
				IsPersistent = loginVM.RememberMe
			};
			var userClaimPrinciple = new ClaimsPrincipal(claimIdentity);


			//var signIn = HttpContext.SignInAsync(new ClaimsPrincipal(claimIdentity),
			//	userManager.AuthenticationOptions(model.RememberMe));

			await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
				userClaimPrinciple, authenticationProperty);

			if (roles.Contains("Admin"))
			{
				return RedirectToAction("Index", "Home", new { Area = "Admin" });
			}
			else
			{
				return RedirectToAction("Index", "Home");
			}



		}
		[HttpGet]
		[AllowAnonymous]
		public async Task<IActionResult> Logout()
		{
			await HttpContext.SignOutAsync();
			return RedirectToAction("Index", "Home");
		}
		[HttpGet]
		[AllowAnonymous]
		public IActionResult UserInsert()
		{

			UserInsertVM userInsertVM = new UserInsertVM();
			return View(userInsertVM);
		}
		[HttpPost]
		[AllowAnonymous]
		public IActionResult UserInsert(UserInsertVM insertVM)
		{


			if (!ModelState.IsValid)
			{

				notyfService.Error("Düzeltilmesi gereken yerler var");
				return View(insertVM);

			}

			// Burada insertvm MyUser sinifina çevrilmesi lazim

			#region 

			//MyUser myUser = new MyUser();
			//myUser.Cinsiyet=insertVM.Cinsiyet;
			//myUser.Ad=insertVM.Ad;
			//myUser.Soyad=insertVM.Soyad;
			//myUser.Email=insertVM.Email;
			//myUser.TcNo=insertVM.TcNo;
			//myUser.Gsm=insertVM.Gsm;
			//myUser.CreateDate=DateTime.Now;
			//myUser.Password=insertVM.Password;
			#endregion
			var myUser = mapper.Map<UserInfo>(insertVM);
			userManager.Create(myUser);

			#region Kullanıcıya Default olarak User rolü eklenir
			// Rolü Veritabanından Çekme

			var role = roleManager.Get(p => p.RoleName == "User");

			if (role == null)
			{
				notyfService.Error("User rolü bulunamadı.");

			}

			// Kullanıcının rollerini başlat
			if (myUser.Roles == null)
				myUser.Roles = new List<Role>();

			// Entity Framework'e rolün mevcut olduğunu bildir
			sqlDbContext.Entry(role).State = EntityState.Unchanged;

			// Eğer kullanıcıda rol zaten eklenmediyse ekle
			if (!myUser.Roles.Any(r => r.RoleName == "User"))
			{
				myUser.Roles.Add(role);
				sqlDbContext.Update(myUser);
				sqlDbContext.SaveChanges();
				notyfService.Success("İşlem başarılı.");
			}
			else
			{
				notyfService.Error("Kullanıcı zaten 'User' rolüne sahip.");
			}
			#endregion








			// userManager.Create(insertVM);

			return RedirectToAction("UserRegisterSuccess", "Account");

		}
		[HttpGet]
		[AllowAnonymous]
		public IActionResult UserRegisterSuccess()
		{

			return View();
		}
	}
}