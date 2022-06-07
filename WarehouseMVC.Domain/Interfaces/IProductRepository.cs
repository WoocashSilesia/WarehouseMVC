using System.Linq;
using WarehouseMVC.Domain.Model;

namespace WarehouseMVC.Domain.Interfaces
{
    public interface IProductRepository
    {
        void DeleteProduct(int productId);
        int AddProduct(Product product);
        IQueryable<Product> GetProductsByType(int typeId);
        Product GetProductById(int id);
    }
}
