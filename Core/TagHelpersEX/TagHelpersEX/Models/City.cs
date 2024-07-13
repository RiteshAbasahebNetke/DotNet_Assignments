using System;
using System.Collections.Generic;

namespace TagHelpersEX.Models
{
    public class City
    {
        public Int64 CityID { get; set; }
        public string CityName { get; set; }

        public static List<City> GetAllCities()
        {
            List<City> ct = new List<City>();
            ct.Add(new City() { CityID = 1,CityName="Pune" });
            ct.Add(new City() { CityID = 2, CityName = "Mumbai" });
            ct.Add(new City() { CityID = 3, CityName = "Delhi" });
            ct.Add(new City() { CityID = 4, CityName = "Noida" });
            ct.Add(new City() { CityID = 5, CityName = "Chennai" });

            return ct;
        }
    }
}
