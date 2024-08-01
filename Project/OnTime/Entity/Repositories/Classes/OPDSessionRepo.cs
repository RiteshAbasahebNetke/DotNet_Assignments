using Core;
using Entity.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repositories.Classes
{
    public class OPDSessionRepo: GenericRepo<OPDSession>, IOPDSessionRepo
    {
        CompanyContext cc;
        public OPDSessionRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }

            public List<OPDSession> GetByOID(long id)
            {
                var v = from t in this.cc.OPDSessions
                        where
                      (from t1 in this.cc.Clinics select t1.ClinicID)
                      .Contains(id) && t.ClinicID == id
                        select t;
                return v.ToList();
            }
    }
}
