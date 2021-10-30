
using Microsoft.EntityFrameworkCore;
using Samaneyar.DataLayer.Mapping.ProductMapping;
using Samaneyar.DataLayer.Shop.ProductAgg;
using Samaneyar.DataLayer.Shop.ProductCategory;

namespace Samaneyar.DataLayer
{
  public  class SamaneyarContext:DbContext
    {
        public SamaneyarContext(DbContextOptions<SamaneyarContext> options):base(options){}

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ProductMap).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
