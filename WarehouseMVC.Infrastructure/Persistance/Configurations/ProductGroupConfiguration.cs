using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseMVC.Domain.Model;

namespace WarehouseMVC.Infrastructure.Persistance.Configurations
{
    class ProductGroupConfiguration : IEntityTypeConfiguration<ProductGroup>
    {
        public void Configure(EntityTypeBuilder<ProductGroup> builder)
        {
            builder
                .Property(a => a.Name)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
