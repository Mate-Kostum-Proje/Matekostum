using AspNetCoreHero.ToastNotification.Abstractions;
using Mate.BL.Abstract;
using Mate.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mate.MVC.Controllers
{
    public class CostumController(IManager<Product> productManager, IManager<ProductSize> productSizeManager, INotyfService notyfService) : Controller
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
        private Product GetProductById(string productId)
        {
            return productManager.GetById(productId);
        }

        [HttpGet]
        public IActionResult CostumInfo(string id)
        {
            // Ürün bilgisini getir
            var product = GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }

            // Ürünü View'e gönder
            return View(product);
        }




        #region CostumInfo deneme
        //public IActionResult CostumInfo(string id)
        //{

        //	var product = productManager.GetById(id);
        //	if (product == null)
        //	{
        //		return NotFound();
        //	}
        //	try
        //	{
        //		// Size bilgilerini çekiyoruz

        //		//burası null geliyor
        //		var sizeOptions = productSizeManager.GetAll()
        //			.Where(ps => ps.ProductId == id)
        //			.Select(ps => new Size
        //			{
        //				SizeNumber = ps.SizeNumber,
        //				Id = ps.SizeId
        //			})
        //			.ToList() ?? new List<Size>();
        //		if (sizeOptions == null || !sizeOptions.Any())
        //		{
        //			notyfService.Error("Beden seçenekleri bulunamadı.");
        //			return View(new AddToBasketVM { SizeOptions = new List<Size>() });
        //		}
        //		else if (!sizeOptions.Any())
        //		{
        //			notyfService.Warning("Mevcut beden seçenekleri bulunamadı.");
        //		}


        //		var model = new AddToBasketVM
        //		{
        //			ProductId = id,
        //			SizeOptions = sizeOptions
        //		};

        //		return View(model); // Ürün detaylarını göstermek için bir View döndürün
        //	}
        //	catch (Exception ex)
        //	{
        //		notyfService.Error("Bir hata oluştu: " + ex.Message);
        //		return RedirectToAction("Error", "Home");
        //	}


        //} 
        #endregion
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
