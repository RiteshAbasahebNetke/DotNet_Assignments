using Microsoft.EntityFrameworkCore;

namespace CurdOpUsing8VersionEx.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context>opt):base(opt) { }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Computer" },
                new Category { CategoryID = 2, CategoryName = "Book" },
                new Category { CategoryID = 3, CategoryName = "Electronics" }
                );
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
