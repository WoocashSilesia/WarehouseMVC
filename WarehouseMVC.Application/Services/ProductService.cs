using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseMVC.Application.Interfaces;

namespace WarehouseMVC.Application.Services
{
    public class ProductService : IProductService
    {
        //private readonly IProductRepository _productRepo;
        //public ProductService(IProductRepository productRepo)
        //{
        //    _productRepo = productRepo;
        //}
        public List<int> GetAllProducts()
        {
            return new List<int>();
        }
    }
}
