using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WarehouseMVC.Application.Interfaces;
using WarehouseMVC.Web.Models;

namespace WarehouseMVC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("All")]
        public IActionResult ViewListOfProducts()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product() { Id = 1, Name = "a" });
            products.Add(new Product() { Id = 2, Name = "b" });
            products.Add(new Product() { Id = 3, Name = "c" });

            return View(products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
