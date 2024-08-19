using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repositories.Interfaces
{
    public interface IClinicRatingRepo : IGenericRepo<ClinicRating> 
    {
        IEnumerable<ClinicRating> GetRatingsByClinicID(Int64 id);
    }
    
}
