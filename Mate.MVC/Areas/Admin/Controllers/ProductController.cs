using Microsoft.AspNetCore.Mvc;

namespace Mate.MVC.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
