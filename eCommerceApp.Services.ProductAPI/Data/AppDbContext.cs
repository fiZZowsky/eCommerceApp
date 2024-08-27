using eCommerceApp.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerceApp.Services.ProductAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Test",
                Price = 15,
                Description = " Test.<br/> Test description.",
                ImageUrl = "https://placehold.co/603x403",
                CategoryName = "Test"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Test2",
                Price = 12.99,
                Description = " Test 2.<br/> Test description 2.",
                ImageUrl = "https://placehold.co/603x402",
                CategoryName = "Test 2"
            });
        }
    }
}
