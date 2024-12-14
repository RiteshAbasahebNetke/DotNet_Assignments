using Microsoft.EntityFrameworkCore;

namespace ApiCurdEx.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> opt) : base(opt) { }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Customer>().HasData(
                new Customer() { CustomerID = 1, CustomerName = "Ramesh", Address = "Nigdi", EmailAddress = "ramesh@gmail.com", MobileNo = "98765403", CreditLimit = 15000 },
                new Customer() { CustomerID = 2, CustomerName = "Sham", Address = "Akurdi", EmailAddress = "sham@gmail.com", MobileNo = "99765403", CreditLimit = 13000 },
                new Customer() { CustomerID = 3, CustomerName = "Raju", Address = "Wakad", EmailAddress = "raju@gmail.com", MobileNo = "98765483", CreditLimit = 10000 }
                );
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
