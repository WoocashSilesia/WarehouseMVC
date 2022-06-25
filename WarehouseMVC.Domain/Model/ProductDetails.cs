using System.Collections.Generic;
using WarehouseMVC.Domain.Common;

namespace WarehouseMVC.Domain.Model
{
    public class ProductDetails : BaseEntity
    {
        public string ExtraName { get; set; }
        public string Supplier { get; set; }
        public string EAN { get; set; }
        public decimal? Price { get; set; }
        public string ProducerCode { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public  ICollection<Feature> Features { get; set; }
        //public ICollection<ProductDimension> ProductDimensions { get; set; }
    }
}
