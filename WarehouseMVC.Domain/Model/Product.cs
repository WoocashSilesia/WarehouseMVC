using System.Collections.Generic;
using WarehouseMVC.Domain.Common;

namespace WarehouseMVC.Domain.Model
{
    public class Product : BaseEntity
    { 
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public bool Active { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public int ProductTypeOfCollectionId { get; set; }
        public ProductTypeOfCollection ProductTypeOfCollection { get; set; }    
        public int? ProductGroupId { get; set; }
        public ProductGroup ProductGroup { get; set; }
        public int UnitId { get; set; }
        public  Unit Unit { get; set; }
        public ProductDetails ProductDetails { get; set; }
        public ICollection<Attachment> Attachments { get; set; }
    }
}
