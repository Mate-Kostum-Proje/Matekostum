using Mate.BL.Abstract;
using Mate.Entities.Concrete;
using Mate.MVC.Models.VMs;
using Microsoft.AspNetCore.Mvc;

namespace Mate.MVC.Controllers
{
	public class BasketController(IBasketManager basketManager, IManager<Product> productRepository) : Controller
	{
		private readonly IBasketManager _basketManager = basketManager;
		private readonly IManager<Product> _productRepository = productRepository;



		// Sepeti görüntüleme
		public IActionResult BasketInside()
		{
			if (User.Identity.IsAuthenticated)
			{
				string userId = User.Identity.Name; // Kullanıcı ID'sini alın
				var basketDetails = _basketManager.GetBasketDetails(userId);

				// BasketDetail ile Product verilerini birleştiriyoruz
				var viewModel = basketDetails.Select(p =>
				{
					var product = _productRepository.GetById(p.ProductId);

					// Fiyatı belirlemek için durumu kontrol et
					int price = 0;
					if (product != null)
					{
						price = product.IsSale
						? (product.UnitPriceForSale ?? 0)
						: (product.UnitPriceForRent);

					}

					return new BasketDetailPipeLine
					{
						ProductId = p.ProductId,
						ProductName = product?.ProductName, // Ürün adı (Product tablosundan alınır)
						Price = price, // Ürün fiyatı
						Amount = p.Amount, // Sepetteki miktar
						TotalPrice = price * p.Amount, // Toplam fiyat
						BasketDetailId = p.Id, // BasketDetail ID'si
						Size = p.ProductSize //Size 
					};
				}).ToList();

				return View(viewModel);
			}
			else
			{
				return RedirectToAction("Login", "Account");
			}
		}



		public ActionResult BasketInsideVol2() //Bundan hiç emin değilim
		{
			string userId = User.Identity.Name; // Kullanıcı ID'sini alın 
			var basketDetails = _basketManager.GetBasketDetails(userId);
			return View(basketDetails); // Sepet detaylarını View'e gönder
		}

		// Sepete ürün ekleme
		[HttpGet]
		public IActionResult AddToBasket()
		{
			ProductVM productVM = new ProductVM();
			return View(productVM);
		}

		// Sepete ürün ekleme

		[HttpPost]
		public async Task<ActionResult> AddToBasket(ProductVM productVM)
		{
			if (User.Identity.IsAuthenticated)
			{
				try
				{

					string userId = User.Identity.Name; // Kullanıcı ID'sini alın
					var basketDetail = new BasketDetail
					{
						//ProductId = productVM.productId,
						Amount = productVM.Amount,
						//ProductSize = productVM.Sizes
					};

					_basketManager.AddToBasket(userId, basketDetail); // İş mantığını çağır
					TempData["Success"] = "Ürün sepete başarıyla eklendi.";
				}
				catch (InvalidOperationException ex)
				{
					TempData["Error"] = ex.Message;
				}
				return RedirectToAction("Index"); // İşlemden sonra sepete yönlendir
			}
			else
			{
				return RedirectToAction("Login", "Account");
			}
		}

		// Sepetten ürün çıkarma
		public ActionResult RemoveFromBasket(string basketDetailId)
		{
			try
			{
				_basketManager.RemoveFromBasket(basketDetailId); // İş mantığını çağır
				TempData["Success"] = "Ürün sepetten başarıyla çıkarıldı.";
			}
			catch (InvalidOperationException ex)
			{
				TempData["Error"] = ex.Message;
			}
			return RedirectToAction("Index");
		}

		// Sepeti temizleme
		public ActionResult ClearBasket()
		{
			string userId = User.Identity.Name; // Kullanıcı ID'sini alın
			_basketManager.ClearBasket(userId); // İş mantığını çağır
			TempData["Success"] = "Sepet başarıyla temizlendi.";
			return RedirectToAction("Index");
		}
		public class BasketDetailPipeLine
		{
			public string BasketDetailId { get; set; } // Sepet Detay ID
			public string ProductId { get; set; } // Ürün ID
			public string ProductName { get; set; } // Ürün adı
			public decimal Price { get; set; } // Ürün fiyatı
			public int Amount { get; set; } // Miktar
			public int Size { get; set; }
			public decimal TotalPrice { get; set; } // Toplam fiyat
		}
	}
}