using Microsoft.EntityFrameworkCore;

namespace CoreCurd.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> opt) : base(opt) { }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<City>().HasData(
                new City() { CityID=1, CityName="Pune"},
                new City() { CityID=2, CityName="Nashik"},
                new City() { CityID=3, CityName="Nagar"},
                new City() { CityID=4, CityName="Satara"}
                );
        }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
