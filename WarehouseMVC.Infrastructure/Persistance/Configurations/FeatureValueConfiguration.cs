using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseMVC.Domain.Model;

namespace WarehouseMVC.Infrastructure.Persistance.Configurations
{
    class FeatureValueConfiguration : IEntityTypeConfiguration<FeatureValue>
    {
        public void Configure(EntityTypeBuilder<FeatureValue> builder)
        {
            builder
               .Property(a => a.StringValue)
               .HasMaxLength(100);

            builder
                .Property(a => a.FeatureTypeId)
                .IsRequired();

            builder
              .Property(a => a.FeatureId)
              .IsRequired();
        }
    }
}
