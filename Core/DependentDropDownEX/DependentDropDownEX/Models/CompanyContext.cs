using Microsoft.EntityFrameworkCore;

namespace DependentDropDownEX.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> opt):base(opt){}

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Country>().HasData(
                new Country { CountryID = 1, CountryName = "India" },
                new Country { CountryID = 2, CountryName = "USA" },
                new Country { CountryID = 3, CountryName = "Japan" }
                );

            mb.Entity<State>().HasData(
                new State { StateID=1, StateName="Maharashtra", CountryID=1},
                new State { StateID=2, StateName="Karnataka", CountryID=1},
                new State { StateID=3, StateName="California", CountryID=2},
                new State { StateID=4, StateName="Texas", CountryID=2},
                new State { StateID=5, StateName= "Hokkaido", CountryID=3 },
                new State { StateID=6, StateName= "Shikoku", CountryID=3 }
                );

            mb.Entity<City>().HasData(
                new City() { CityID = 1, StateID = 1, CityName = "Mumbai" },
                new City() { CityID = 2, StateID = 1, CityName = "Pune" },
                new City() { CityID = 3, StateID = 1, CityName = "PCMC" },
                new City() { CityID = 4, StateID = 2, CityName = "Bengluru" },
                new City() { CityID = 5, StateID = 2, CityName = "Mangaluru" },
                new City() { CityID = 6, StateID = 2, CityName = "Kalburga" },
                new City() { CityID = 7, StateID = 3, CityName = "Los Aneles" },
                new City() { CityID = 8, StateID = 3, CityName = "San Francisco" },
                new City() { CityID = 9, StateID = 4, CityName = "Hostun" },
                new City() { CityID = 10, StateID = 4, CityName = "Dallas" },
                new City() { CityID = 11, StateID = 5, CityName = "Sapporo" }
                );
        }
        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
