using AspNetCoreHero.ToastNotification.Abstractions;
using Mate.BL.Abstract;
using Mate.Entities.Concrete;
using Mate.MVC.Models.VMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mate.MVC.Controllers
{
    public class ContactController(IManager<CommUser> commUserManager, INotyfService notyfService) : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [AllowAnonymous] // Burasi Herkese açik hale gelir
        public IActionResult İletişim()
        {
            ContactVM contactVM = new ContactVM();
            return View(contactVM);
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult İletişim(ContactVM contactVM)
        {
            if (!ModelState.IsValid)
            {

                notyfService.Error("Düzeltilmesi gereken yerler var");
                return View(contactVM);

            }


            else
            {
                CommUser commUser = new CommUser();
                commUser.Email = contactVM.Email;
                commUser.Subject = contactVM.Subject;
                commUser.Name = contactVM.Name;
                commUser.Message = contactVM.Message;
                commUser.CreatedAt = DateTime.Now;


                commUserManager.Create(commUser);




                return RedirectToAction("CommUserSuccess", "Contact");
            }
        }
        public IActionResult CommUserSuccess()
        {
            return View();
        }
    }
}
