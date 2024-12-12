using Mate.BL.Abstract;
using Mate.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Mate.MVC.Models.Components
{
    public class BasketDetailsViewComponent : ViewComponent
    {
        private readonly IManager<BasketDetail> basketDetail;

        public BasketDetailsViewComponent(IManager<BasketDetail> basketDetail)
        {
            this.basketDetail = basketDetail;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Bu bolum Daha sonra degistirilecek. Gelen Kullanicinin Role'une gore veriler cekilecek
            var basketDetails = basketDetail.GetAll();
            return View(basketDetails);
        }
    }
}