using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WarehouseMVC.Domain.Common;

namespace WarehouseMVC.Domain.Model
{
    public class ProductGroup : BaseEntity
    {
        [MaxLength(100)]
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public virtual ProductGroup Parent { get; set; }
        public virtual ICollection<ProductGroup> Children { get; set; }
    }
}
