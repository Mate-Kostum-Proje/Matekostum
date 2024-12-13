using Mate.BL.Abstract;
using Mate.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Mate.MVC.Models.Components
{
    public class İletişimViewComponent : ViewComponent
    {
        private readonly IManager<SiteCommInfo> siteCommInfo;

        public İletişimViewComponent(IManager<SiteCommInfo> siteCommInfo)
        {
            this.siteCommInfo = siteCommInfo;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Bu bolum Daha sonra degistirilecek. Gelen Kullanicinin Role'une gore veriler cekilecek
            var siteCommInfos = siteCommInfo.GetAll();
            return View(siteCommInfos);
        }
    }
}