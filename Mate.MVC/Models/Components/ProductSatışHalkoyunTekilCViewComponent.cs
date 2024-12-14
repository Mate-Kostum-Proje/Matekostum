using Mate.BL.Abstract;
using Mate.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Mate.MVC.Models.Components
{
    public class ProductSatışHalkoyunTekilCViewComponent : ViewComponent
    {
        private readonly IManager<Product> product;

        public ProductSatışHalkoyunTekilCViewComponent(IManager<Product> product)
        {
            this.product = product;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var products = product.GetAll();
            return View(products);
        }
    }
}