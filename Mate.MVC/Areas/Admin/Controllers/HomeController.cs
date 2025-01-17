﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ticari.WebMVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = "Admin")]


    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var cookies = HttpContext.Request.Cookies;
            return View();
        }
    }
}