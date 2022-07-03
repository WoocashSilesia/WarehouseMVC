using System.Linq;
using WarehouseMVC.Domain.Interfaces;
using WarehouseMVC.Domain.Model;

namespace WarehouseMVC.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;
        public ProductRepository(Context context)
        {
            _context = context;
        }

        public void DeleteProduct(int productId)
        {
            var product = _context.Products.Find(productId);
            if (product != null)
            {
                product.Active = false;
                _context.Products.Update(product);
                _context.SaveChanges();
            }
        }

        public int AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product.Id;
        }

        public int EditProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
            return product.Id;
        }

        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Product> GetAllActiveProducts()
        {
            return _context.Products.AsQueryable();
        }
    }
}
