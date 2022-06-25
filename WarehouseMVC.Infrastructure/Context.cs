using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
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

        public Context(DbContextOptions options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
