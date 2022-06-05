using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WarehouseMVC.Domain.Common;

namespace WarehouseMVC.Domain.Model
{
    public class ProductDetails : BaseEntity
    {
        [MaxLength(100)]
        public string ExtraName { get; set; }
        [MaxLength(100)]
        public string Supplier { get; set; }
        [MaxLength(100)]
        public string EAN { get; set; }
        public decimal Price { get; set; }
        public bool Active { get; set; }
        [MaxLength(100)]
        public string ProducerCode { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        public virtual ICollection<Feature> ProductFeatures { get; set; }
        //public virtual ICollection<ProductDimension> ProductDimensions { get; set; }
    }
}
