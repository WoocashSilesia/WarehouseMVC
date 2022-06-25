using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WarehouseMVC.Domain.Common;

namespace WarehouseMVC.Domain.Model
{
    public class Unit : BaseEntity
    {
        public string Name { get; set; }
        public string Shortcut { get; set; }
        public bool Indivisible { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
