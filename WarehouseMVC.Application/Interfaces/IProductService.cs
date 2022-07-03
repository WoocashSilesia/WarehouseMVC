using WarehouseMVC.Application.ViewModels.Product;

namespace WarehouseMVC.Application.Interfaces
{
    public interface IProductService
    {
        ListProductForListResponseVm GetAllProductsForList();
        ProductDetailsResponseVm GetProductDetails(int id);
        int AddProduct(ProductAddRequestVm model);
        int EditProduct(ProductEditRequestVm model);
        void DeleteProduct(int id);
    }
}
