﻿
namespace PlatinumStars.Controllers
{
    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
    using PlaneBuyingSystem.Web.ViewModels.Home;
    

    public class HomeController : Controller
    {
        private readonly IPlaneService planeService;

        public HomeController()
        {           
        }

        public IActionResult Index()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}