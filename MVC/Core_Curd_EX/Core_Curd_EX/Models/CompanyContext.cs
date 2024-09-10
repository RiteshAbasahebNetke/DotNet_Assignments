using Microsoft.EntityFrameworkCore;

namespace Core_Curd_EX.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> opt) : base(opt) { }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Area>().HasData(
                new Area() { AreaID=1,AreaName="Pimpri"},
                new Area() { AreaID=2,AreaName="Chinchwad"},
                new Area() { AreaID=3,AreaName="Nigdi"},
                new Area() { AreaID=4,AreaName="Akurdi"}
                );
        }
        public DbSet<Customer> Customers { get; set; }  
        public DbSet<Area> Areas { get; set; }
    }
}
