using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseMVC.Domain.Model;

namespace WarehouseMVC.Infrastructure.Persistance.Configurations
{
    class UnitConfiguration : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder
                .Property(a => a.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(a => a.Shortcut)
                .HasMaxLength(20)
                .IsRequired();

            builder
                .Property(a => a.Indivisible)
                .IsRequired();
        }
    }
}
