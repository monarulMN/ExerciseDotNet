using Exercise.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercise.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Asif", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Ali", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Ahmed", DisplayOrder = 3 }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Fortune of Time",
                    Author = "Belly Spark",
                    Description = "Praesent vitas sodales labriares ",
                    ISBN = "SWD99967386",
                    ListPrice = 87,
                    Price = 34,
                    Price50 =65,
                    Price100 = 123,
                    CategoryId = 1,
                    ImageUrl =""
                    
                },
                new Product
                {
                    Id = 2,
                    Title = "Fortune of Albam",
                    Author = "Belly wall",
                    Description = "Praesent vitas sodales labriares ",
                    ISBN = "SWD343467386",
                    ListPrice = 45,
                    Price = 32,
                    Price50 = 76,
                    Price100 = 143,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "Computer",
                    Author = "Hardware",
                    Description = "Praesent vitas sodales labriares ",
                    ISBN = "SWD3434534386",
                    ListPrice = 23,
                    Price = 45,
                    Price50 = 75,
                    Price100 = 154,
                    CategoryId = 3,
                    ImageUrl = ""
                }
                );
        }
    }
}
