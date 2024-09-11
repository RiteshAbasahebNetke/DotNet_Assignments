using Core_Repo_Test.Models;
using Core_Repo_Test.Repositories.Interfaces;

namespace Core_Repo_Test.Repositories.Classes
{
    public class CityRepo : ICityRepo
    {
        FlightContext fc;
        public CityRepo(FlightContext fc)
        {
            this.fc = fc;
        }
        public List<City> GetCities()
        {
            return this.fc.Cities.ToList();
        }
    }
}
