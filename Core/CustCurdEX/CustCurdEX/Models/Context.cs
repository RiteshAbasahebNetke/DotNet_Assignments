using Microsoft.EntityFrameworkCore;

namespace CustCurdEX.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> opt):base(opt) { }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Area>().HasData(
                new Area { AreaID = 1, AreaName = "Akurdi" },
                new Area { AreaID = 2, AreaName = "Pimpri" },
                new Area { AreaID = 3, AreaName = "Nigdi" },
                new Area { AreaID = 4, AreaName = "Wakad" }
                );
        }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
