using BasicCRUDOperation.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicCRUDOperation.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }


        //here we are seeding the data or adding the data to the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product {
                    Id = 1,
                    Name = "Samsung",
                    Price = 100
                },
                new Product
                {
                    Id = 2,
                    Name = "IPhone",
                    Price = 200
                },
                new Product
                {
                    Id = 3,
                    Name = "Appo",
                    Price = 150
                }
            );
        }
    }
}
