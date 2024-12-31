using System.Data;
using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Mate.BL.Abstract;
using Mate.DAL.DbContexts;
using Mate.Entities.Concrete;
using Mate.MVC.Areas.Admin.Models_VMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Mate.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class OrderAdminController(IManager<OrderDetail> orderDetailManager
                                    , IManager<OrderSituation> orderSituationManager
                                    , IManager<UserInfo> userManager
                                    , IManager<Order> orderManager
                                    , SqlDbContext sqlDbContext
                                    , INotyfService notyfService
                                    , IMapper mapper
                                    , IHostEnvironment hostEnvironment) : Controller
    {

        [Authorize]
        public IActionResult Index()
        {
            var orderDetails = orderDetailManager.GetAllInclude()
                .Include(od => od.Orders)
                    .ThenInclude(o => o.UserInfos)
                .Include(od => od.Products)
                .Include(od => od.OrderSituations)
                .ToList();

            var viewModel = orderDetails.Select(od => new OrderDetailsAdminVM
            {
                OrderDetailId = od.Id,
                OrderId = od.OrderId,
                CustomerName = od.Orders.UserInfos.Name,
                CustomerSurname = od.Orders.UserInfos.SurName,
                CustomerTcNo = od.Orders.UserInfos.TcNo,
                CustomerPhone = od.Orders.UserInfos.GSM,
                CustomerAddress = od.Orders.UserInfos.Address,
                CustomerCity = od.Orders.UserInfos.City,
                CustomerDistrict = od.Orders.UserInfos.District,
                ProductName = od.Products?.ProductName,
                ProductSize = od.ProductSize,
                Amount = od.Amount,
                TotalPrice = od.TotalPrice,
                SituationName = od.SituationName,
                Situations = orderSituationManager.GetAll().Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.Situation
                }).ToList(),
                SelectedSituationId = od.SituationId
            }).ToList();

            return View(viewModel);
        }

        [Authorize]
        [HttpPost]

        public IActionResult UpdateSituation(string orderDetailId, string situationId)
        {
            if (string.IsNullOrEmpty(orderDetailId) || string.IsNullOrEmpty(situationId))
            {
                notyfService.Error("Hata algılandı");
                return RedirectToAction("Index");
            }

            var orderDetail = orderDetailManager.GetById(orderDetailId);

            if (orderDetail == null)
            {
                notyfService.Warning("Sipariş Detayı Bulunamadı");
                return RedirectToAction("Index");
            }

            orderDetail.SituationId = situationId;
            orderDetail.SituationName = orderSituationManager.Get(p => p.Id == situationId).Situation;
            orderDetailManager.Update(orderDetail);

            notyfService.Success("Sipariş Durumu güncellendi");
            return RedirectToAction("Index", new { orderDetailId });
        }
    }
}

