using System;
using System.Reflection;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products{get;set;}
        public DbSet<ProductBrand> ProductBrands{get;set;}
        public DbSet<ProductType> ProductTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public Task<object> GetProductBrandsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> GetProductTypesAsync()
        {
            throw new NotImplementedException();
        }
    }
}