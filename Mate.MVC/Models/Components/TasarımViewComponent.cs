using Mate.BL.Abstract;
using Mate.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Mate.MVC.Models.Components
{
	public class TasarımViewComponent : ViewComponent
	{
		private readonly IManager<FotoDesign> designGalery;

		public TasarımViewComponent(IManager<FotoDesign> designGalery)
		{
			this.designGalery = designGalery;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var designGaleries = designGalery.GetAll();
			return View(designGaleries);
		}
	}

}