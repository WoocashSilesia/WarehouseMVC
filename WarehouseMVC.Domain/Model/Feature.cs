using System.ComponentModel.DataAnnotations;
using WarehouseMVC.Domain.Common;

namespace WarehouseMVC.Domain.Model
{
    public class Feature : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public FeatureValue FeatureValue { get; set; }
        public int ProductDetailsId { get; set; }
        public ProductDetails ProductDetails { get; set; }
    }
}
