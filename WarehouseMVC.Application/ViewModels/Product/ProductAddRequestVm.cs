namespace WarehouseMVC.Application.ViewModels.Product
{
    public class ProductAddRequestVm : ProductEditRequestVm
    {
        public string Name { get; set; }
        public string ExtraName { get; set; }
        public string ProductCode { get; set; }
        public string ProducerCode { get; set; }
        public string Supplier { get; set; }
        public string EAN { get; set; }
    }
}
