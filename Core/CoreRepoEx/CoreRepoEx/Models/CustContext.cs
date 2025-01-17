using Microsoft.EntityFrameworkCore;

namespace CoreRepoEx.Models
{
    public class CustContext:DbContext
    {
        public CustContext(DbContextOptions<CustContext> opt):base(opt) { }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Area>().HasData(
                new Area() { AreaID = 1, AreaName = "Nigdi" },
                new Area() { AreaID = 2, AreaName = "Akurdi" },
                new Area() { AreaID = 3, AreaName = "Wagholi" },
                new Area() { AreaID = 4, AreaName = "Kothrud" }
                );
        }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
