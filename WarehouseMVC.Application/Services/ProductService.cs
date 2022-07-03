using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Linq;
using WarehouseMVC.Application.Interfaces;
using WarehouseMVC.Application.ViewModels.Product;
using WarehouseMVC.Domain.Interfaces;

namespace WarehouseMVC.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepo;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository productRepo, IMapper mapper)
        {
            _productRepo = productRepo;
            _mapper = mapper;
        }

        public int AddProduct(ProductAddRequestVm model)
        {
            throw new NotImplementedException();
        }

        public int EditProduct(ProductEditRequestVm model)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public ListProductForListResponseVm GetAllProductsForList()
        {
            ListProductForListResponseVm response = new ListProductForListResponseVm();
            response.Products = _productRepo.GetAllActiveProducts().ProjectTo<ProductForListResponseVm>(_mapper.ConfigurationProvider).ToList();
            response.Count = response.Products.Count();
            return response;
        }

        public ProductDetailsResponseVm GetProductDetails(int id)
        {
            var product = _productRepo.GetProductById(id);
            var productVm = _mapper.Map<ProductDetailsResponseVm>(product);

            return productVm;
        }
    }
}
