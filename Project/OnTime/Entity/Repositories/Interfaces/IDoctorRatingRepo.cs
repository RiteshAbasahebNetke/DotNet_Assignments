using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repositories.Interfaces
{
    public interface IDoctorRatingRepo:IGenericRepo<DoctorRating> 
    {
        
        IEnumerable<DoctorRating> GetRatingsByDoctorID(Int64 id);
    }
}
