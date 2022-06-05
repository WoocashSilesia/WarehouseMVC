using System.ComponentModel.DataAnnotations;
using WarehouseMVC.Domain.Common;

namespace WarehouseMVC.Domain.Model
{
    public class Feature : BaseEntity
    {
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        public FeatureValue FeatureValue { get; set; }
        public int ProductDetailsId { get; set; }
        public virtual ProductDetails ProductDetails { get; set; }
    }
}
