using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WarehouseMVC.Domain.Common;
using WarehouseMVC.Domain.Enums;

namespace WarehouseMVC.Domain.Model
{
    public class Product : BaseEntity
    { 
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string ProductCode { get; set; }
        public bool Active { get; set; }
        public int ProductDetailsId { get; set; }
        public int ProductGroupId { get; set; }
        public int UnitId { get; set; }
        public int ProductTypeId { get; set; }
        public int ProductTypeOfCollectionId { get; set; }
        public virtual ProductType ProductType{ get; set; }
        public virtual ProductTypeOfCollection ProductTypeOfCollection { get; set; }
        public virtual ProductDetails ProductDetails { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual ICollection<Attachment> Attachments { get; set; }
    }
}
