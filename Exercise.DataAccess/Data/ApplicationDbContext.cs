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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Asif", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Ali", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Ahmed", DisplayOrder = 3 }
            );
        }
    }
}
