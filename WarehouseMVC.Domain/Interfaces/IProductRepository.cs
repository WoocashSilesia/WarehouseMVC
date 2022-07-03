using System.Linq;
using WarehouseMVC.Domain.Model;

namespace WarehouseMVC.Domain.Interfaces
{
    public interface IProductRepository
    {
        void DeleteProduct(int productId);
        int AddProduct(Product product);
        int EditProduct(Product product);
        IQueryable<Product> GetAllActiveProducts();
        Product GetProductById(int id);
    }
}
