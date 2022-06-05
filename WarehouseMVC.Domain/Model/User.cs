using WarehouseMVC.Domain.Common;

namespace WarehouseMVC.Domain.Model
{
    public class User : BaseEntity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
    }
}
