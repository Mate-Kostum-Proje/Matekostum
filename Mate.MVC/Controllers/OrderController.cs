using Microsoft.AspNetCore.Mvc;

namespace Mate.MVC.Controllers
{
	public class OrderController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
