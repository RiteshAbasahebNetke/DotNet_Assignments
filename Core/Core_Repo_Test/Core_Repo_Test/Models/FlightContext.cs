using Microsoft.EntityFrameworkCore;

namespace Core_Repo_Test.Models
{
    public class FlightContext:DbContext
    {
        public FlightContext(DbContextOptions<FlightContext> opt) : base(opt) { }
        public DbSet<City> Cities { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Flights> Flights { get; set; }
        public DbSet<FlightFacilities> FlightsFacilities { get; set;}
    }
}
