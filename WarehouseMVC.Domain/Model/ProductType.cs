using System.Collections.Generic;
using WarehouseMVC.Domain.Common;

namespace WarehouseMVC.Domain.Model
{
    public class ProductType : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
