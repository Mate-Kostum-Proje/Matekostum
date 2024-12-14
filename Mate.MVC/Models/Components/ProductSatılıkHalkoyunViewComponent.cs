using Mate.BL.Abstract;
using Mate.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Mate.MVC.Models.Components
{
	public class ProductSatılıkHalkoyunViewComponent : ViewComponent
	{
		private readonly IManager<Product> product;

		public ProductSatılıkHalkoyunViewComponent(IManager<Product> product)
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