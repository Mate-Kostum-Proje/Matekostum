﻿using Mate.BL.Abstract;
using Mate.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Mate.MVC.Models.Components
{
    public class OrderDetailsViewComponent : ViewComponent
    {
        private readonly IManager<OrderDetail> orderDetail;

        public OrderDetailsViewComponent(IManager<OrderDetail> orderDetail)
        {
            this.orderDetail = orderDetail;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Bu bolum Daha sonra degistirilecek. Gelen Kullanicinin Role'une gore veriler cekilecek
            var orderDetails = orderDetail.GetAll();
            return View(orderDetails);
        }
    }
}