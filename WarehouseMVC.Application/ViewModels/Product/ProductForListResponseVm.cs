using WarehouseMVC.Application.Mapping;

namespace WarehouseMVC.Application.ViewModels.Product
{
    public class ProductForListResponseVm : IMapFrom<WarehouseMVC.Domain.Model.Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public string ExtraName { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }
        public string GroupName { get; set; }

        public void Mapping(MappingProfile profile)
        {
            profile.CreateMap<WarehouseMVC.Domain.Model.Product, ProductForListResponseVm>()
                .ForMember(pr => pr.ExtraName, src => src.MapFrom(p => p.ProductDetails.ExtraName))
                .ForMember(pr => pr.Price, src => src.MapFrom(p => p.ProductDetails.Price))
                .ForMember(pr => pr.Unit, src => src.MapFrom(p => p.Unit.Name))
                .ForMember(pr => pr.GroupName, src => src.MapFrom(p => p.ProductGroup.Name));
        }
    }
}
