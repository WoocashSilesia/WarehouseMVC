using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarehouseMVC.Application.Interfaces;

namespace WarehouseMVC.Web.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return View();
        }

        [HttpGet("{id}")]
        public IActionResult GetSingleProduct(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPut]
        public IActionResult UpdateProduct()
        {
            return View();
        }
    }
}
