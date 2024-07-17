using Microsoft.EntityFrameworkCore;

namespace CustomAuthorizeFilter.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> opt) : base(opt) { }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Product>().HasData(
                new Product() { ProductID=1,ProductName="Mouse",MfgName="Intex",Price=460},
                new Product() { ProductID=2,ProductName="Monitor",MfgName="Dell",Price=7890},
                new Product() { ProductID=3,ProductName="MotherBoard",MfgName="Circle",Price=4567},
                new Product() { ProductID=4,ProductName="Charger",MfgName="Lenovo",Price=2340}
                );

            mb.Entity<User>().HasData(
                new User() { UserID=1,FirstName="Ramesh",LastName="Sharma",EmailID="ramesh@hotmail.com",MobileNo="847582901",Password="abcd"}
                );
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
