using Core;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repositories.Interfaces
{
    public interface IClinicRatingRepo : IGenericRepo<ClinicRating> 
    {
        void Add(ClinicRatingVM rec);
        List<ClinicRatingVM> GetRatingsByClinicID(Int64 id);
    }
    
}
