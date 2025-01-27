using Microsoft.EntityFrameworkCore;

namespace AssignmentCoreEx.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context>opt):base(opt) { }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ProductCategory>().HasData(
                new ProductCategory { ProductCategoryID = 1, CategoryName = "Computer" },
                new ProductCategory { ProductCategoryID = 2, CategoryName = "Cloths" },
                new ProductCategory { ProductCategoryID = 3, CategoryName = "Electronics" }
                );

            mb.Entity<Color>().HasData(
                new Color { ColorID = 1, ColorName = "Red" },
                new Color { ColorID = 2, ColorName = "Black" },
                new Color { ColorID = 3, ColorName = "Violet" },
                new Color { ColorID = 4, ColorName = "Brown" }
                );

            mb.Entity<Mfg>().HasData(
                new Mfg { MfgID = 1, MfgName = "Intex", Address = "Wagholi", EmailID = "intex@gmail.com", MobileNo = "120946573" },
                new Mfg { MfgID = 2, MfgName = "Polo", Address = "Pimpri", EmailID = "polo@gmail.com", MobileNo = "120946573" },
                new Mfg { MfgID = 3, MfgName = "Samsung", Address = "Baner", EmailID = "samsunng@gmail.com", MobileNo = "120046573" },
                new Mfg { MfgID = 4, MfgName = "Denim", Address = "Chinchwad", EmailID = "denim@gmail.com", MobileNo = "120906573" }
                );
        }

        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Mfg> Mfgs { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
