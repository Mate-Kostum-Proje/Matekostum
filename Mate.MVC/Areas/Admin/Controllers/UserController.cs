using System.Security.Claims;
using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Mate.BL.Abstract;
using Mate.Entities.Concrete;
using Mate.MVC.Areas.Admin.Models_VMs;
using Mate.MVC.Models.VMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Mate.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class UserController(IManager<UserInfo> userManager
                                , INotyfService notyfService
                                , IMapper mapper
                                , IManager<Role> roleManager
                                , IHostEnvironment hostEnvironment) : Controller
    {
        public IActionResult Index()
        {
            var users = userManager.GetAllInclude(null, p => p.Roles).ToList();
            return View(users);
        }
        [HttpGet]
        public IActionResult UserInsert()
        {

            UserInsertAdminVM userInsertVM = new UserInsertAdminVM();
            var roles = roleManager.GetAll();
            foreach (var role in roles)
            {
                CheckBoxVM checkBoxVM = new CheckBoxVM()
                {
                    Id = role.Id,
                    LabelName = role.RoleName,
                    IsChecked = false
                };
                userInsertVM.Roles.Add(checkBoxVM);

            }
            return View(userInsertVM);
        }
        [HttpPost]
        public async Task<IActionResult> UserInsert(UserInsertAdminVM insertVM)
        {

            if (!ModelState.IsValid)
            {

                notyfService.Error("Düzeltilmesi gereken yerler var");
                return View(insertVM);
            }


            // Burada insertvm MyUser sinifina çevrilmesi lazim


            var myUser = new UserInfo();

            myUser = mapper.Map<UserInfo>(insertVM);

            var user = userManager.Get(p => p.Email == myUser.Email);
            if (user != null)
            {
                notyfService.Success("Bu email kullanilmaktadir");
                return View(insertVM);
            }
            var usertcno = userManager.Get(p => p.TcNo == myUser.TcNo);
            if (usertcno != null)
            {
                notyfService.Success("Bu TcNo kullanilmaktadir");
                return View(insertVM);
            }
            try
            {
                userManager.Create(myUser);
                myUser.Roles = new List<UsersRoles>();

                #region Kullaniciya check edilen rollerin atanmasi
                foreach (var item in insertVM.Roles.Where(p => p.IsChecked == true).ToList())
                {
                    var role = roleManager.GetById(item.Id);
                    myUser.Roles.Add(new UsersRoles
                    {
                        RoleId = role.Id // Sadece var olan RoleId kullanılıyor
                    });
                }

                userManager.Update(myUser);

            }
            catch (SqlException sqlException)
            {

                notyfService.Error("Hata Olustu :" + sqlException.InnerException);
                return View(insertVM);
            }
            catch (Exception ex)
            {
                var message = ex.InnerException.Message.Split(".")[2];
                notyfService.Error("Hata Olustu :" + message);
                return View(insertVM);
            }

            #endregion
            notyfService.Success("Islem Basarili");



            // userManager.Create(insertVM);

            return RedirectToAction("Index", "User", new { Area = "Admin" });

        }

        public IActionResult GetUser()
        {
            var email = User.FindFirstValue(ClaimTypes.Email);
            var user = userManager.GetAllInclude(p => p.Email == email, p => p.Roles).FirstOrDefault();

            return View(user);
        }
    }
}