using AspNetCoreHero.ToastNotification.Abstractions;
using Mate.BL.Abstract;
using Mate.Entities.Concrete;
using Mate.MVC.Models.VMs;
using Microsoft.AspNetCore.Mvc;

namespace Mate.MVC.Controllers
{
	public class BasketController(IBasketManager basketManager
								, IManager<Product> productRepository
								, IManager<ProductSize> productSizeRepository
								, IManager<Size> sizeRepository
								, INotyfService notyfService) : Controller
	{
		private readonly IBasketManager _basketManager = basketManager;
		private readonly IManager<Product> _productRepository = productRepository;
		private readonly IManager<ProductSize> _productSizeRepository = productSizeRepository;
		private readonly IManager<Size> _sizeRepository = sizeRepository;


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



		//public ActionResult BasketInsideVol2() //Bundan hiç emin değilim
		//{
		//	string userId = User.Identity.Name; // Kullanıcı ID'sini alın 
		//	var basketDetails = _basketManager.GetBasketDetails(userId);
		//	return View(basketDetails); // Sepet detaylarını View'e gönder
		//}

		// Sepete ürün ekleme
		[HttpGet]
		public IActionResult AddToBasket()
		{
			ProductVM productVM = new ProductVM();
			return View(productVM);
		}

		// Sepete ürün ekleme

		[HttpPost]
		public async Task<ActionResult> AddToBasket(ProductVM productVM, AddToBasketVM addToBasketVM, ProductSize productSize)
		{
			if (User.Identity.IsAuthenticated)
			{
				try
				{

					// Size tablosundan ilgili ProductId için beden bilgilerini çekiyoruz
					productSize = _productSizeRepository.GetAll()
					.FirstOrDefault(ps => ps.ProductId == addToBasketVM.ProductId && ps.SizeNumber == addToBasketVM.SizeNumber);

					if (productSize == null)
					{
						notyfService.Error("Seçilen beden mevcut değil.");
						return RedirectToAction("CostumInfo", new { id = addToBasketVM.ProductId });
					}
					string userId = User.Identity.Name; // Kullanıcı ID'sini alın
					var basketDetail = new BasketDetail
					{
						ProductId = addToBasketVM.ProductId,
						Amount = addToBasketVM.Amount,
						ProductSize = addToBasketVM.SizeNumber,

					};

					// Sepete ekleme işlemi
					_basketManager.AddToBasket(userId, basketDetail, productSize);

					// Başarı mesajı
					notyfService.Success("Ürün sepete başarıyla eklendi.");
				}
				catch (InvalidOperationException ex)
				{
					// Hata mesajı
					notyfService.Error(ex.Message);
				}

				// İşlemden sonra sepete yönlendir
				return RedirectToAction("InsideBasket");
			}
			else
			{
				// Giriş yapılmadıysa login sayfasına yönlendir
				return RedirectToAction("Login", "Account");
			}
		}





		// Sepetten ürün çıkarma
		public ActionResult RemoveFromBasket(string basketDetailId)
		{
			try
			{
				_basketManager.RemoveFromBasket(basketDetailId); // İş mantığını çağır
				notyfService.Success("Ürün sepetten başarıyla çıkarıldı.");

			}
			catch (InvalidOperationException ex)
			{
				notyfService.Error(ex.Message);
			}
			return RedirectToAction("BasketInside");
		}

		// Sepeti temizleme
		public ActionResult ClearBasket()
		{
			string userId = User.Identity.Name; // Kullanıcı ID'sini alın
			_basketManager.ClearBasket(userId); // İş mantığını çağır
			notyfService.Success("Sepet başarıyla temizlendi.");

			return RedirectToAction("BasketInside");
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