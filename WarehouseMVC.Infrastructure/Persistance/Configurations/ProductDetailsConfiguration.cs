using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseMVC.Domain.Model;

namespace WarehouseMVC.Infrastructure.Persistance.Configurations
{
    class ProductDetailsConfiguration : IEntityTypeConfiguration<ProductDetails>
    {
        public void Configure(EntityTypeBuilder<ProductDetails> builder)
        {
            builder
                .Property(a => a.ExtraName)
                .HasMaxLength(100);

            builder
                .Property(a => a.Supplier)
                .HasMaxLength(100);

            builder
                .Property(a => a.EAN)
                .HasMaxLength(100);

            builder
                .Property(a => a.ProducerCode)
                .HasMaxLength(100);

            builder
                .Property(a => a.Description)
                .HasMaxLength(100);

            builder
                .Property(a => a.ProductId)
                .IsRequired();
        }
    }
}
