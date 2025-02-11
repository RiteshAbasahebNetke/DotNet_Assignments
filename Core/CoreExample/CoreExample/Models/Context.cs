using CurdCoreExample.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreExample.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context>opt) : base(opt) { }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Electronics" },
                new Category { CategoryID = 2, CategoryName = "Computer" },
                new Category { CategoryID = 3, CategoryName = "Cloths" }
                );
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
