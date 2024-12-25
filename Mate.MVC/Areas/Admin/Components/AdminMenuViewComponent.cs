using Mate.BL.Abstract;
using Mate.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Mate.MVC.Areas.Admin.Components
{
	public class AdminMenuViewComponent : ViewComponent
	{
		private readonly IManager<MainMenu> menuManager;

		public AdminMenuViewComponent(IManager<MainMenu> menuManager)
		{
			this.menuManager = menuManager;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{

			var menuler = menuManager.GetAll();
			return View(menuler);
		}
	}
}
