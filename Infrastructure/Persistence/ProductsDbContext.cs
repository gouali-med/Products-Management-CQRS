
using Microsoft.EntityFrameworkCore;

using System;
using Domain;

namespace Persistence
{
    public class ProductsDbContext : DbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options)
           : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var categoryGuid = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7C5DDE}");
            var productGuid = Guid.Parse("{6313179F-7837-473A-A4D5-A5571B43E6A6}");
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = categoryGuid,
                Name = "Technology"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = productGuid,
                Name = "Introduction to CQRS and Mediator Patterns",
                Price =10 ,
               // Picture = "https://api.khalidessaadani.com/uploads/articles_bg.jpg",
                CategoryId = categoryGuid
            });

        }
    }

}
