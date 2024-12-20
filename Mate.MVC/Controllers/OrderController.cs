using Mate.BL.Abstract;
using Mate.Entities.Concrete;
using Mate.MVC.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mate.MVC.Controllers
{
	public class OrderController(IOrderManager orderManager) : Controller
	{
		private readonly IOrderManager _orderManager = orderManager;

		// Sipariş Oluştur
		[HttpPost]
		[Authorize] // Sadece giriş yapmış kullanıcılar sipariş oluşturabilir
		public IActionResult PlaceOrder(List<OrderDetail> orderDetails, List<ProductSize> productSizes)
		{
			string userId = User.Identity.GetId(); // Kullanıcının ID'sini alın

			try
			{
				bool result = _orderManager.PlaceOrder(userId, orderDetails, productSizes);

				if (result)
				{
					TempData["SuccessMessage"] = "Sipariş başarıyla oluşturuldu.";
					return RedirectToAction("Index", "Order");
				}
				else
				{
					TempData["ErrorMessage"] = "Sipariş oluşturulamadı.";
					return RedirectToAction("BasketInside", "Basket");
				}
			}
			catch (InvalidOperationException ex)
			{
				TempData["ErrorMessage"] = ex.Message;
				return RedirectToAction("BasketInside", "Basket");
			}
		}

		// Ürün Güncelleme - Sadece Admin erişebilir
		[HttpPost]
		[Authorize(Roles = "Admin")] // Sadece Admin yetkisine sahip kullanıcılar erişebilir
		public IActionResult Update(Product product)
		{
			try
			{
				_orderManager.Update(product);
				TempData["SuccessMessage"] = "Ürün başarıyla güncellendi.";
				return RedirectToAction("ProductList", "Product");
			}
			catch (InvalidOperationException ex)
			{
				TempData["ErrorMessage"] = ex.Message;
				return RedirectToAction("ProductList", "Product");
			}
		}

		// Sipariş Detaylarını Görüntüle
		//[HttpGet]
		//[Authorize] // Sadece giriş yapmış kullanıcılar erişebilir
		//public IActionResult Details(int orderId)
		//{
		//	var orderDetails = _orderManager.GetOrderDetails(orderId);
		//	if (orderDetails == null)
		//	{
		//		return NotFound();
		//	}

		//	return View(orderDetails);
		//}

		//// Siparişler Listesi (Admin için)
		//[HttpGet]
		//[Authorize(Roles = "Admin")] // Sadece Admin yetkisine sahip kullanıcılar erişebilir
		//public IActionResult Index()
		//{
		//	var orders = _orderManager.GetAllOrders();
		//	return View(orders);
		//}
	}
}
