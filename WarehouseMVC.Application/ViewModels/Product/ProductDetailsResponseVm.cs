using WarehouseMVC.Application.Mapping;

namespace WarehouseMVC.Application.ViewModels.Product
{
    public class ProductDetailsResponseVm : IMapFrom<WarehouseMVC.Domain.Model.Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public string ProductType { get; set; }
        public string ProductTypeOfCollection { get; set; }
        public string FullGroupName { get; set; }
        public string Unit { get; set; }
        public string ExtraName { get; set; }
        public string Supplier { get; set; }
        public string EAN { get; set; }
        public decimal Price { get; set; }
        public string ProducerCode { get; set; }
        public string Description { get; set; }

        public void Mapping(MappingProfile profile)
        {
            profile.CreateMap<WarehouseMVC.Domain.Model.Product, ProductDetailsResponseVm>()
                .ForMember(pr => pr.ProductType, src => src.MapFrom(p => p.ProductType.Name))
                .ForMember(pr => pr.ProductTypeOfCollection, src => src.MapFrom(p => p.ProductTypeOfCollection.Name))
                .ForMember(pr => pr.FullGroupName, src => src.MapFrom(p => p.ProductGroup.Name)) //TODO load all parents
                .ForMember(pr => pr.Unit, src => src.MapFrom(p => p.Unit.Name))
                .ForMember(pr => pr.ExtraName, src => src.MapFrom(p => p.ProductDetails.ExtraName))
                .ForMember(pr => pr.Supplier, src => src.MapFrom(p => p.ProductDetails.Supplier))
                .ForMember(pr => pr.EAN, src => src.MapFrom(p => p.ProductDetails.EAN))
                .ForMember(pr => pr.Price, src => src.MapFrom(p => p.ProductDetails.Price))
                .ForMember(pr => pr.Description, src => src.MapFrom(p => p.ProductDetails.Description));
        }
    }
}
