using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Mate.BL.Abstract;
using Mate.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mate.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProductContoller(IManager<Product> productManager
                            , INotyfService notyfService
                            , IMapper mapper
                            , IHostEnvironment hostEnvironment) : Controller
    {
        public IActionResult Index()
        {
            var products = productManager.GetAllInclude().ToList();
            return View(products);
        }
        public IActionResult ProductInsert()
        {
            return View();
        }
        public IActionResult ProductEdit()
        {
            return View();
        }
        public IActionResult ProductDelete()
        {
            return View();
        }
    }
}
