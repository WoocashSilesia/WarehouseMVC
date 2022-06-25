using System.ComponentModel.DataAnnotations;
using WarehouseMVC.Domain.Common;

namespace WarehouseMVC.Domain.Model
{
    public class Attachment : BaseEntity
    {
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [MaxLength(20)]
        public string Format { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
