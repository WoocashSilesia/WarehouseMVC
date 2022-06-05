using System.ComponentModel.DataAnnotations;
using WarehouseMVC.Domain.Common;

namespace WarehouseMVC.Domain.Model
{
    public class Unit : BaseEntity
    {
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string Shortcut { get; set; }
        public bool Indivisible { get; set; }
    }
}
