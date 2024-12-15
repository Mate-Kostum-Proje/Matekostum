using Mate.BL.Abstract;
using Mate.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mate.MVC.Controllers
{
	public class CostumController(IManager<Product> productManager) : Controller
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
		[HttpGet]
		public IActionResult CostumInfo(string id)
		{
			var product = productManager.GetById(id); // Ürünü veritabanından getirin
			if (product == null)
			{
				return NotFound();
			}

			return View(product); // Ürün detaylarını göstermek için bir View döndürün
		}
		public IActionResult ProductKiralık()
		{
			return View();
		}
		public IActionResult ProductSatılık()
		{
			return View();
		}
		public IActionResult ProductKiralıkHalkoyun()
		{
			return View();
		}
		public IActionResult ProductKiralıkDans()
		{
			return View();
		}
		public IActionResult ProductKiralıkBindal()
		{
			return View();
		}
		public IActionResult ProductKiralıkRond()
		{
			return View();
		}
		public IActionResult ProductSatılıkHalkoyun()
		{
			return View();
		}
	}
}
