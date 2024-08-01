using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repositories.Interfaces
{
    public interface IOPDSessionRepo : IGenericRepo<OPDSession> 
    {
        List<OPDSession> GetByOID(Int64 id);
    }
    
}
