﻿using AspNetCoreHero.ToastNotification.Abstractions;
using Mate.BL.Abstract;
using Mate.Entities.Concrete;
using Mate.MVC.Extensions;
using Mate.MVC.Models.VMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mate.MVC.Controllers
{
    public class OrderController(IOrderManager orderManager, IBasketManager basketManager, IManager<UserInfo> userManager, IManager<Product> productManager, IManager<OrderSituation> orderSituationManager, INotyfService notyfService) : Controller
    {
        private readonly IManager<Product> _productRepository = productManager;
        private readonly IOrderManager _orderManager = orderManager;
        private readonly IManager<UserInfo> _userManager = userManager;
        private readonly IBasketManager _basketManager = basketManager;
        private readonly IManager<OrderSituation> _orderSituationManager = orderSituationManager;

        private readonly DbContext _dbContext;
        // Sipariş Oluştur
        [HttpPost]
        [Authorize]
        public IActionResult PlaceOrder(List<OrderDetail> orderDetails, List<ProductSize> productSizes)
        {
            string userId = User.Identity.GetId(); // Kullanıcının ID'sini alma =>Extension yazıldı
            var userBasket = basketManager.GetBasketDetails(userId);
            try
            {
                // Sepetin boş olup olmadığını kontrol etme
                if (userBasket == null || !userBasket.Any())
                {
                    notyfService.Error("Sepetiniz boş, sipariş verilecek ürün bulunamadı.");
                    return RedirectToAction("BasketInside", "Basket");
                }
                // Stok kontrolü ve sipariş oluşturma
                if (_orderManager.CanPlaceOrder(userId, orderDetails, productSizes))
                {
                    return RedirectToAction("Payment", "Order");
                }
                else
                {
                    notyfService.Error("Sipariş oluşturulamadı. Yetersiz stok.");
                    return RedirectToAction("BasketInside", "Basket");
                }
            }
            catch (InvalidOperationException ex)
            {
                notyfService.Error(ex.Message);
                return RedirectToAction("BasketInside", "Basket");
            }
            catch (Exception ex)
            {
                // Beklenmedik bir hata oluşursa genel bir hata mesajı gösterme
                notyfService.Error("Sipariş sırasında beklenmedik bir hata oluştu. Lütfen tekrar deneyin.");
                // Hatanın loglanması (opsiyonel)
                // _logger.LogError(ex, "PlaceOrder işleminde hata oluştu.");
                return RedirectToAction("BasketInside", "Basket");
            }
        }


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
                notyfService.Error("Veriler eksik veya geçersiz.");
                return RedirectToAction("BasketInside", "Basket");
            }
            string userId = User.Identity.GetId();

            if (string.IsNullOrWhiteSpace(paymentVM.CardHolderName) ||
                string.IsNullOrWhiteSpace(paymentVM.CardNumber) ||
                string.IsNullOrWhiteSpace(paymentVM.CVV) ||
                string.IsNullOrWhiteSpace(paymentVM.ExpirationDate))
            {
                notyfService.Error("Ödeme bilgileri eksik.");
                return RedirectToAction("Payment", "Basket");
            }

            {
                try
                {

                    // Sipariş oluştur ve stokları güncelle
                    if (_orderManager.PlaceOrder(userId, orderDetails, productSizes, products))
                    {

                        notyfService.Success("Ödemeniz başarıyla alındı ve sipariş oluşturuldu.");
                        return RedirectToAction("OrderDetails", "Order");
                    }
                    else
                    {

                        notyfService.Error("Sipariş sırasında bir hata oluştu.");
                        return RedirectToAction("BasketInside", "Basket");
                    }
                }
                catch (InvalidOperationException ex)
                {

                    notyfService.Error(ex.Message);
                    return RedirectToAction("BasketInside", "Basket");
                }
            }
        }

        // Sipariş Detayları
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> OrderDetails()
        {
            string userId = User.Identity.GetId(); // Kullanıcı ID'sini alın
            var orderDetails = _orderManager.GetOrderDetails(userId);


            if (orderDetails == null || !orderDetails.Any())
            {
                // Kullanıcıyı bir hata sayfasına yönlendirebilir, boş bir model dönebilir
                notyfService.Information("Henüz bir siparişiniz bulunmamaktadır.");
                return View();
            }
            #region Gereksiz kalan kısım
            //string orderId = orderDetails.FirstOrDefault().OrderId.ToString();
            ////string orderId = orderDetails.FirstOrDefault().OrderId.ToString();
            ////string orderSituation = _orderManager.GetAll(p => p.Id == orderId).FirstOrDefault().OrderSituations.Situation;
            //string orderSituation = _orderManager.GetAllInclude(o => o.Id == orderId, o => o.OrderSituations).FirstOrDefault().OrderSituations.Situation;


            //// BasketDetail ile Product verilerini birleştiriyoruz
            //var viewModel = orderDetails.Select(p =>
            //{
            //    var product = _productRepository.GetById(p.ProductId);

            //    // Fiyatı belirlemek için durumu kontrol et
            //    int price = 0;
            //    if (product != null)
            //    {
            //        price = product.IsSale
            //        ? (product.UnitPriceForSale ?? 0)
            //        : (product.UnitPriceForRent);

            //    }

            //    return new OrderDetailsVM
            //    {
            //        OrderId = orderId,
            //        ProductId = p.ProductId,
            //        ProductName = product?.ProductName, // Ürün adı (Product tablosundan alınır)
            //        Price = price, // Ürün fiyatı
            //        Amount = p.Amount, // Sepetteki miktar
            //        TotalPrice = price * p.Amount, // Toplam fiyat
            //        OrderDetailId = p.Id, // BasketDetail ID'si
            //        Size = p.ProductSize, //Size 
            //        IsSale = product.IsSale,
            //        OrderSituation = orderSituation,
            //        CreatedDate = p.CreatedAt



            //    };
            //}).ToList(); 
            #endregion

            return View();
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
                notyfService.Success("Ürün başarıyla güncellendi.");
                return RedirectToAction("ProductList", "Product");
            }
            catch (InvalidOperationException ex)
            {
                notyfService.Error(ex.Message);
                return RedirectToAction("ProductList", "Product");
            }
        }
    }
}
