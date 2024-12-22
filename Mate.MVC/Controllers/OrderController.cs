using AspNetCoreHero.ToastNotification.Abstractions;
using Mate.BL.Abstract;
using Mate.Entities.Concrete;
using Mate.MVC.Extensions;
using Mate.MVC.Models.VMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mate.MVC.Controllers
{
    public class OrderController(IOrderManager orderManager, IBasketManager basketManager, IManager<UserInfo> userManager, INotyfService notyfService) : Controller
    {
        private readonly IOrderManager _orderManager = orderManager;
        private readonly IManager<UserInfo> _userManager = userManager;
        private readonly INotyfService _notyfService = notyfService;
        private readonly IBasketManager _basketManager = basketManager;
        private readonly DbContext _dbContext;
        // Sipariş Oluştur
        [HttpPost]
        [Authorize]
        public IActionResult PlaceOrder(List<OrderDetail> orderDetails, List<ProductSize> productSizes)
        {
            string userId = User.Identity.GetId(); // Kullanıcının ID'sini alın

            try
            {
                // Stok kontrolü ve sipariş oluşturma
                if (_orderManager.CanPlaceOrder(userId, orderDetails, productSizes))
                {
                    return RedirectToAction("Payment", "Order");
                }
                else
                {
                    _notyfService.Error("Sipariş oluşturulamadı. Yetersiz stok.");
                    return RedirectToAction("BasketInside", "Basket");
                }
            }
            catch (InvalidOperationException ex)
            {
                _notyfService.Error(ex.Message);
                return RedirectToAction("BasketInside", "Basket");
            }
        }

        // Sipariş Ödeme
        [HttpGet]
        [Authorize]
        public IActionResult Payment()
        {
            string userId = User.Identity.GetId();
            var totalPrice = _basketManager.CalculateTotalPrice(userId);

            PaymentVM paymentVM = new PaymentVM
            {
                Amount = totalPrice // Ödenecek tutarı belirle
            };

            return View(paymentVM);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Payment(PaymentVM paymentVM, List<OrderDetail> orderDetails, List<ProductSize> productSizes, List<Product> products, List<BasketDetail> basketDetails)
        {
            if (paymentVM == null || orderDetails == null || productSizes == null)
            {
                _notyfService.Error("Veriler eksik veya geçersiz.");
                return RedirectToAction("BasketInside", "Basket");
            }
            string userId = User.Identity.GetId();

            if (string.IsNullOrWhiteSpace(paymentVM.CardHolderName) ||
                string.IsNullOrWhiteSpace(paymentVM.CardNumber) ||
                string.IsNullOrWhiteSpace(paymentVM.CVV) ||
                string.IsNullOrWhiteSpace(paymentVM.ExpirationDate))
            {
                _notyfService.Error("Ödeme bilgileri eksik.");
                return RedirectToAction("Payment", "Basket");
            }

            {
                try
                {

                    // Sipariş oluştur ve stokları güncelle
                    if (_orderManager.PlaceOrder(userId, orderDetails, productSizes, products, basketDetails))
                    {

                        _notyfService.Success("Ödemeniz başarıyla alındı ve sipariş oluşturuldu.");
                        return RedirectToAction("OrderDetails", "Order");
                    }
                    else
                    {

                        _notyfService.Error("Sipariş sırasında bir hata oluştu.");
                        return RedirectToAction("BasketInside", "Basket");
                    }
                }
                catch (InvalidOperationException ex)
                {

                    _notyfService.Error(ex.Message);
                    return RedirectToAction("BasketInside", "Basket");
                }
            }
        }

        // Sipariş Detayları
        [HttpGet]
        [Authorize]
        public IActionResult OrderDetails(string orderId)
        {
            var orderDetails = _orderManager.GetOrderDetails(orderId);
            if (orderDetails == null)
            {
                return NotFound();
            }

            return View(orderDetails);
        }

        // Siparişler Listesi (Admin için)
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var orders = _orderManager.GetAllOrders();
            return View(orders);
        }

        // Ürün Güncelleme (Admin)
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Update(Product product)
        {
            try
            {
                _orderManager.Update(product);
                _notyfService.Success("Ürün başarıyla güncellendi.");
                return RedirectToAction("ProductList", "Product");
            }
            catch (InvalidOperationException ex)
            {
                _notyfService.Error(ex.Message);
                return RedirectToAction("ProductList", "Product");
            }
        }
    }
}
