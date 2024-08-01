using Core;
using Entity.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repositories.Classes
{
    public class ClinicFacilityRepo:GenericRepo<ClinicFacility>,IClinicFacilityRepo
    {
        CompanyContext cc;
        public ClinicFacilityRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }

        List<ClinicFacility> IClinicFacilityRepo.GetByCID(long id)
        {
            var v = from t in this.cc.ClinicFacilities
                    where
                  (from t1 in this.cc.Clinics select t1.ClinicID)
                  .Contains(id) && t.ClinicID == id select t;
            return v.ToList();
        }
    }
}
