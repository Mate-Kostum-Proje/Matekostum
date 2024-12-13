using Mate.BL.Abstract;
using Mate.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Mate.MVC.Models.Components
{
    public class ProductSatışHalkoyunViewComponent : ViewComponent
    {
        private readonly IManager<Product> product;

        public ProductSatışHalkoyunViewComponent(IManager<Product> product)
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