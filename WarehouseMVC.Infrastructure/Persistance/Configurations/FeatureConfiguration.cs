using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseMVC.Domain.Model;

namespace WarehouseMVC.Infrastructure.Persistance.Configurations
{
    class FeatureConfiguration : IEntityTypeConfiguration<Feature>
    {
        public void Configure(EntityTypeBuilder<Feature> builder)
        {
            builder
                .HasOne(f => f.FeatureValue).WithOne(fv => fv.Feature)
                .HasForeignKey<FeatureValue>(fv => fv.FeatureId);

            builder
                .Property(f => f.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .HasIndex(f => f.Name)
                .IsUnique();

            builder
                .Property(f => f.ProductDetailsId)
                .IsRequired();
        }
    }
}
