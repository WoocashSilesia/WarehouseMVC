using System;
using System.ComponentModel.DataAnnotations;
using WarehouseMVC.Domain.Common;

namespace WarehouseMVC.Domain.Model
{
    public class FeatureValue : BaseEntity
    {
        public int FeatureTypeId { get; set; }
        public double? DoubleFrom { get; set; }
        public double? DoubleTo { get; set; }
        public int? IntFrom { get; set; }
        public int? IntTo { get; set; }
        public DateTime? DateTimeFrom { get; set; }
        public DateTime? DateTimeTo { get; set; }
        public bool? BoolValue { get; set; }
        [MaxLength(100)]
        public string StringValue { get; set; }
        public virtual FeatureType FeatureType { get; set; }
    }
}
