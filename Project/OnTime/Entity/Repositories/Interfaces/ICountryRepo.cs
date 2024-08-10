using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repositories.Interfaces
{
    public interface ICountryRepo : IGenericRepo<Country> 
    {
        List<Doctor> GetCountry(Int64 CountryID);
    }
    
}
