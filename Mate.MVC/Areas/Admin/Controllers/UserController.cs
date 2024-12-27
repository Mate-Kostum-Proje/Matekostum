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
        public async Task<IActionResult> UserInsert(UserInsertAdminVM userInsertVM)
        {

            if (!ModelState.IsValid)
            {

                notyfService.Error("Düzeltilmesi gereken yerler var");
                return View(userInsertVM);
            }


            // Burada insertvm MyUser sinifina çevrilmesi lazim


            var myUser = new UserInfo();

            #region Welcome to Amele Yöntemi

            myUser.Name = userInsertVM.Name;
            myUser.SurName = userInsertVM.SurName;
            myUser.Email = userInsertVM.Email;
            myUser.TcNo = userInsertVM.TcNo;
            myUser.GSM = userInsertVM.GSM;
            myUser.City = userInsertVM.City;
            myUser.District = userInsertVM.District;
            myUser.Address = userInsertVM.Address;
            myUser.Password = userInsertVM.Password;



            #endregion

            // myUser = mapper.Map<UserInfo>(userInsertVM);


            var user = userManager.Get(p => p.Email == myUser.Email);
            if (user != null)
            {
                notyfService.Success("Bu email kullanilmaktadir");
                return View(userInsertVM);
            }
            var usertcno = userManager.Get(p => p.TcNo == myUser.TcNo);
            if (usertcno != null)
            {
                notyfService.Success("Bu TcNo kullanilmaktadir");
                return View(userInsertVM);
            }
            try
            {
                userManager.Create(myUser);
                myUser.Roles = new List<UsersRoles>();

                #region Kullaniciya check edilen rollerin atanmasi
                foreach (var item in userInsertVM.Roles.Where(p => p.IsChecked == true).ToList())
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
                return View(userInsertVM);
            }
            catch (Exception ex)
            {
                var message = ex.InnerException.Message.Split(".")[2];
                notyfService.Error("Hata Olustu :" + message);
                return View(userInsertVM);
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
        [HttpGet]
        [Authorize]
        public IActionResult EditUser(string userId)
        {
            // Kullanıcı bilgilerini al


            var user = userManager.GetAllInclude(p => p.Id == userId, p => p.Roles).FirstOrDefault();

            if (user == null)
            {
                notyfService.Error("Kullanıcı bulunamadı.");
                return RedirectToAction("Index");
            }

            // Kullanıcı bilgilerini VM'ye eşle
            var userEditVM = new UserEditAdminVM();

            #region Welcome to Amele Yöntemi

            userEditVM.Id = userId;
            userEditVM.Name = user.Name;
            userEditVM.SurName = user.SurName;
            userEditVM.Email = user.Email;
            userEditVM.TcNo = user.TcNo;
            userEditVM.GSM = user.GSM;
            userEditVM.City = user.City;
            userEditVM.District = user.District;
            userEditVM.Address = user.Address;
            #endregion


            // Rolleri yükle ve seçili olanları işaretle
            var roles = roleManager.GetAll();
            foreach (var role in roles)
            {
                userEditVM.Roles.Add(new CheckBoxVM
                {
                    Id = role.Id,
                    LabelName = role.RoleName,
                    IsChecked = user.Roles.Any(r => r.RoleId == role.Id)
                });
            }

            return View(userEditVM);
        }

        [HttpPost]
        [Authorize]

        public IActionResult EditUser(UserEditAdminVM editVM)
        {
            string userId = editVM.Id;
            //editVM.Id = Id;
            // Kullanıcıyı bul
            var user = userManager.GetAllInclude(p => p.Id == userId, p => p.Roles).FirstOrDefault();

            if (user == null)
            {
                notyfService.Error("Kullanıcı bulunamadı.");
                return RedirectToAction("Index");
            }

            if (!ModelState.IsValid)
            {
                notyfService.Error("Lütfen hataları düzeltin.");
                return View(editVM);
            }

            try
            {
                var userEditVM = new UserEditAdminVM();
                // Kullanıcı bilgilerini güncelle
                userId = editVM.Id;
                user.Name = editVM.Name;
                user.SurName = editVM.SurName;
                user.Email = editVM.Email;
                user.TcNo = editVM.TcNo;
                user.GSM = editVM.GSM;
                user.City = editVM.City;
                user.District = editVM.District;
                user.Address = editVM.Address;

                // Rolleri güncelle
                user.Roles.Clear();
                foreach (var item in editVM.Roles.Where(r => r.IsChecked))
                {
                    user.Roles.Add(new UsersRoles
                    {
                        RoleId = item.Id
                    });
                }

                userManager.Update(user);
                notyfService.Success("Kullanıcı başarıyla güncellendi.");
            }
            catch (Exception ex)
            {
                notyfService.Error("Hata oluştu: " + ex.Message);
                return View(editVM);
            }

            return RedirectToAction("Index");
        }
        //[HttpGet]
        //public IActionResult DeleteUser()
        //{
        //    var userId = User.Identity.GetId();
        //    if (userId == null)
        //    {
        //        notyfService.Error("Kullanıcı bulunamadı.");
        //        return RedirectToAction("Index");
        //    }

        //    // Ürünü View'e gönder
        //    return RedirectToAction("Index", "User");
        //}

        [HttpGet]
        public IActionResult DeleteUser(string userId)
        {
            try
            {
                //Kullanıcıyı bul
                var user = userManager.GetAllInclude(p => p.Id == userId, p => p.Roles).FirstOrDefault();

                if (user == null)
                {
                    notyfService.Error("Kullanıcı bulunamadı.");
                    return RedirectToAction("Index");
                }

                // Kullanıcıyı sil
                userManager.Delete(user);
                notyfService.Success("Kullanıcı başarıyla silindi.");
            }
            catch (Exception ex)
            {
                notyfService.Error("Hata oluştu: " + ex.Message);
            }

            return RedirectToAction("Index");
        }

    }
}