using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseMVC.Domain.Model;

namespace WarehouseMVC.Infrastructure.Persistance.Configurations
{
    class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .HasOne(p => p.ProductDetails).WithOne(pd => pd.Product)
                .HasForeignKey<ProductDetails>(p => p.ProductId);

            builder
                .Property(p => p.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .HasIndex(p => p.Name)
                .IsUnique();

            builder
                .Property(p => p.ProductCode)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(p => p.UnitId)
                .IsRequired();
        }
    }
}
