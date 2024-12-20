using Mate.BL.Abstract;
using Mate.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Mate.MVC.Models.Components
{
	public class SizeOptionsViewComponent : ViewComponent
	{
		private readonly IManager<ProductSize> productSizeManager;


		public SizeOptionsViewComponent(IManager<ProductSize> productSizeManager)
		{
			this.productSizeManager = productSizeManager;
		}

		public async Task<IViewComponentResult> InvokeAsync(string productId)
		{
			var sizeOptions = productSizeManager.GetAll()
				.Where(ps => ps.ProductId == productId)
				.Select(ps => new Size
				{
					SizeNumber = ps.SizeNumber,
					Id = ps.SizeId
				})
				.ToList();

			return View(sizeOptions);
		}
	}

}
//public class SizeOptionsViewComponent : ViewComponent
//{

//	private readonly IManager<Size> size;


//	public SizeOptionsViewComponent(IManager<Size> size)
//	{

//		this.size = size;
//	}

//	public async Task<IViewComponentResult> InvokeAsync()
//	{
//		var sizes = size.GetAll();
//		return View(sizes);
//	}
//}