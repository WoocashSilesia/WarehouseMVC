using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WarehouseMVC.Domain.Model;

namespace WarehouseMVC.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Product> ProductTyps { get; set; }
        public DbSet<User> Users { get; set; }

        public Context(DbContextOptions options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
    }
}
