using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mate.MVC.Controllers
{
    public class CostumController : Controller
    {
        [Authorize]

        public IActionResult Index(string page)
        {
            return View();
        }

        public IActionResult Tasarım()
        {
            return View();
        }
    }
}
