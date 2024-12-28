using Microsoft.AspNetCore.Mvc;

namespace Mate.MVC.Areas.Admin.Controllers
{
    public class OrderAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
