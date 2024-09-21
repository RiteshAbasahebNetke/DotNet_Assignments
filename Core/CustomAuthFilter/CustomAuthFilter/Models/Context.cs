using Microsoft.EntityFrameworkCore;

namespace CustomAuthFilter.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> opt) : base(opt) { }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Product>().HasData(
                new Product() { ProductID = 1, ProductName = "Mouse", MfgName = "Intex", Price = 460 },
                new Product() { ProductID = 2, ProductName = "KeyBoard", MfgName = "Dell", Price = 1230 },
                new Product() { ProductID=3,ProductName="HardDisk",MfgName="Segate",Price=4560},
                new Product() { ProductID=4,ProductName="Monitor",MfgName="LG",Price=9870}
                );

            mb.Entity<User>().HasData(
                new User() { UserID=1,FirstName="Ramesh",LastName="Sharma",EmailID="ramesh@hotmailcom",Password="abc",MobileNo="7539482023"}
                );
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
