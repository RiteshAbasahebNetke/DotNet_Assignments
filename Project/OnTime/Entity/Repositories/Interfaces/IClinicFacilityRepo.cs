using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repositories.Interfaces
{
    public interface IClinicFacilityRepo : IGenericRepo<ClinicFacility> 
    {
        List<ClinicFacility> GetByCID(Int64 id);
    }
    
}
