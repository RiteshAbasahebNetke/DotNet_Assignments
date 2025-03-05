using Microsoft.EntityFrameworkCore;

namespace CoreCurdEg.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> opt) : base(opt) { }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Area>().HasData(
                new Area { AreaID = 1, AreaName = "Nigdi" },
                new Area { AreaID = 2, AreaName = "Akurdi" },
                new Area { AreaID = 3, AreaName = "Pimpri" },
                new Area { AreaID = 4, AreaName = "Chinchwad" }
                );
        }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
