using Microsoft.EntityFrameworkCore;

namespace CurdApiEx.Models
{
    public class CustContext:DbContext
    {
        public CustContext(DbContextOptions<CustContext> opt) : base(opt) { }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Customer>().HasData(
                new Customer() { CustomerID=1,CustomerName="Rajesh",EmailID="rajesh@hotmail.com",Address="Nigdi",CreditLimit=8000},
                new Customer() { CustomerID=2,CustomerName="Suresh",EmailID="suresh@gmailmail.com",Address="Akurdi",CreditLimit=12000},
                new Customer() { CustomerID=3,CustomerName="Ramesh",EmailID="ramesh@hotmail.com",Address="Pimpri",CreditLimit=15000}
                );
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
