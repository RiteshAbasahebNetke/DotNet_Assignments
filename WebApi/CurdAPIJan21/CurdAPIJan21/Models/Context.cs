using Microsoft.EntityFrameworkCore;

namespace CurdAPIJan21.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> opt) : base(opt) { }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Product>().HasData(
                new Product { ProductID = 1, ProductName = "Mouse", MfgName = "Intex", Price = 450 },
                new Product { ProductID = 2, ProductName = "Charger", MfgName = "Mi", Price = 780 },
                new Product { ProductID = 3, ProductName = "Printer", MfgName = "HP", Price = 6700 },
                new Product { ProductID = 4, ProductName = "HardDisk", MfgName = "Seggate", Price = 4500 }
                );
        }
        public DbSet<Product> Products { get; set; }
    }
}
