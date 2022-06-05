using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseMVC.Application.Interfaces
{
    public interface IProductService
    {
        List<int> GetAllProducts();

    }
}
