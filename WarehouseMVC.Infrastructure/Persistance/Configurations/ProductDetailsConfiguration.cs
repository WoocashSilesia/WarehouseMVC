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
                .Property(pd => pd.ExtraName)
                .HasMaxLength(100);

            builder
                .Property(pd => pd.Supplier)
                .HasMaxLength(100);

            builder
                .Property(pd => pd.EAN)
                .HasMaxLength(100);

            builder
                .Property(pd => pd.ProducerCode)
                .HasMaxLength(100);

            builder
                .Property(pd => pd.Description)
                .HasMaxLength(100);

            builder
                .Property(pd => pd.ProductId)
                .IsRequired();

            builder
                .Property(pd => pd.Price)
                .HasPrecision(18, 2);
        }
    }
}
