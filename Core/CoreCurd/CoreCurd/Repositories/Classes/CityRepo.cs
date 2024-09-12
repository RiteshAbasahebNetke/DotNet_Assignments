using CoreCurd.Models;
using CoreCurd.Repositories.Interfaces;

namespace CoreCurd.Repositories.Classes
{
    public class CityRepo : ICityRepo
    {
        Context cc;
        public CityRepo(Context cc)
        {
            this.cc = cc;
        }
        public List<City> GetCities()
        {
            return this.cc.Cities.ToList();
        }
    }
}
