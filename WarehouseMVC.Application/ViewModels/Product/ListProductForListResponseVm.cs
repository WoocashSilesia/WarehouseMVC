using System.Collections.Generic;

namespace WarehouseMVC.Application.ViewModels.Product
{
    public class ListProductForListResponseVm
    {
        public List<ProductForListResponseVm> Products { get; set; }
        public int Count { get; set; }
    }
}
