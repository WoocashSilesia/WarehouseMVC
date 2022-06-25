using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseMVC.Domain.Model;

namespace WarehouseMVC.Infrastructure.Persistance.Configurations
{
    class AttachmentConfiguration : IEntityTypeConfiguration<Attachment>
    {
        public void Configure(EntityTypeBuilder<Attachment> builder)
        {
            builder
                .Property(a => a.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(a => a.ProductId)
                .IsRequired();
        }
    }
}
