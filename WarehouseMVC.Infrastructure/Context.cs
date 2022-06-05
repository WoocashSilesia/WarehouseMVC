using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WarehouseMVC.Domain.Model;

namespace WarehouseMVC.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FeatureType> FeatureTypes { get; set; }
        public DbSet<FeatureValue> FeatureValues { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetails> ProductDetails { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductTypeOfCollection> ProductTypeOfCollections { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<User> Users { get; set; }

        public Context(DbContextOptions options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Feature>()
                .HasOne(f => f.FeatureValue).WithOne(fv => fv.Feature)
                .HasForeignKey<FeatureValue>(fv => fv.FeatureId);

            builder.Entity<FeatureType>()
                .HasOne(ft => ft.FeatureValue).WithOne(fv => fv.FeatureType)
                .HasForeignKey<FeatureValue>(fv => fv.FeatureTypeId);

            builder.Entity<Product>()
                .HasOne(p => p.ProductDetails).WithOne(pd => pd.Product)
                .HasForeignKey<ProductDetails>(p => p.ProductId);
        }
    }
}
