﻿using Mate.BL.Abstract;
using Mate.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Mate.MVC.Models.Components
{
	public class ProductKiralıkDansTekilAdultViewComponent : ViewComponent
	{

		private readonly IManager<Product> product;

		public ProductKiralıkDansTekilAdultViewComponent(IManager<Product> product)
		{
			this.product = product;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			// Bu bolum Daha sonra degistirilecek. Gelen Kullanicinin Role'une gore veriler cekilecek
			var products = product.GetAll();
			return View(products);
		}
	}
}