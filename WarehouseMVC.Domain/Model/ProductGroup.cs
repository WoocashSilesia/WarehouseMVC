using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WarehouseMVC.Domain.Common;

namespace WarehouseMVC.Domain.Model
{
    public class ProductGroup : BaseEntity
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public ProductGroup Parent { get; set; }
        public ICollection<ProductGroup> Children { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
