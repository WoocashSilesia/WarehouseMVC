using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseMVC.Domain.Model;

namespace WarehouseMVC.Infrastructure.Persistance.Configurations
{
    class FeatureTypeConfiguration : IEntityTypeConfiguration<FeatureType>
    {
        public void Configure(EntityTypeBuilder<FeatureType> builder)
        {
            builder
                .HasOne(ft => ft.FeatureValue).WithOne(fv => fv.FeatureType)
                .HasForeignKey<FeatureValue>(fv => fv.FeatureTypeId);

            builder
                .Property(a => a.Name)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
