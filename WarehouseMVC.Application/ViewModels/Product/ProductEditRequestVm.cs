namespace WarehouseMVC.Application.ViewModels.Product
{
    public class ProductEditRequestVm
    {
        public int Id { get; set; }
        public int ProductTypeId { get; set; }
        public int ProductTypeOfCollectionId { get; set; }
        public int? ProductGroupId { get; set; }
        public int UnitId { get; set; }
        public bool Active { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
