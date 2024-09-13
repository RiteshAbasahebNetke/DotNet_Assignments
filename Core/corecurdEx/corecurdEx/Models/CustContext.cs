using Microsoft.EntityFrameworkCore;

namespace corecurdEx.Models
{
    public class CustContext:DbContext
    {
        public CustContext(DbContextOptions<CustContext> opt) : base(opt) { }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Area>().HasData(
                new Area() { AreaID=1,AreaName="Pimpri"},
                new Area() { AreaID=2,AreaName="Nigdi"},
                new Area() { AreaID=3,AreaName="Akurdi"},
                new Area() { AreaID=4,AreaName="Ravet"}
                );
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Area> Area { get; set; }
    }
}
