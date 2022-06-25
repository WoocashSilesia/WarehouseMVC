using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseMVC.Domain.Model;

namespace WarehouseMVC.Infrastructure.Persistance.Configurations
{
    class ProductTypeOfCollectionConfiguration : IEntityTypeConfiguration<ProductTypeOfCollection>
    {
        public void Configure(EntityTypeBuilder<ProductTypeOfCollection> builder)
        {
            builder
                .Property(a => a.Name)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
