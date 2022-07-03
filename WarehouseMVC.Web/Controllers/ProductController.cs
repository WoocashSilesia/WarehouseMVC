using Microsoft.AspNetCore.Mvc;
using WarehouseMVC.Application.Interfaces;
using WarehouseMVC.Application.ViewModels.Product;

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
            var modelVm = _productService.GetAllProductsForList();
            return View(modelVm);
        }

        [HttpGet("{id}")]
        public IActionResult GetSingleProduct(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(ProductAddRequestVm model)
        {
            var id = _productService.AddProduct(model);
            return View(id);
        }

        [HttpPut]
        public IActionResult UpdateProduct(ProductEditRequestVm model)
        {
            var id = _productService.EditProduct(model);
            return View(id);
        }

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            _productService.DeleteProduct(id);
            return View();
        }
    }
}
