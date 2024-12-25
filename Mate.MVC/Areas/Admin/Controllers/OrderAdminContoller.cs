using Microsoft.AspNetCore.Mvc;

namespace Mate.MVC.Areas.Admin.Controllers
{
    public class OrderAdminContoller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
