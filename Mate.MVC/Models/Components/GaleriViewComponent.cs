using Mate.BL.Abstract;
using Mate.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Mate.MVC.Models.Components
{
	public class GaleriViewComponent : ViewComponent
	{
		private readonly IManager<FotoGalery> fotoGalery;

		public GaleriViewComponent(IManager<FotoGalery> fotoGalery)
		{
			this.fotoGalery = fotoGalery;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			// Bu bolum Daha sonra degistirilecek. Gelen Kullanicinin Role'une gore veriler cekilecek
			var fotoGaleries = fotoGalery.GetAll();
			return View(fotoGaleries);
		}
	}
}