using Core;
using Entity.Repositories.Interfaces;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repositories.Classes
{
    public class StateRepo : GenericRepo<State>, IStateRepo
    {
        CompanyContext cc;
        public StateRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }
        public List<Doctor> GetState(long StateID, long SpecilityID)
        {
            var v = from t in this.cc.Doctors join
                    t1 in this.cc.Areas on t.AreaID equals t1.AreaID join
                  t2 in this.cc.Cities on t1.CityID equals t2.CityID join
                  t3 in this.cc.States on t2.StateID equals t3.StateID join
                  t4 in this.cc.DoctorSpecialities on t.DoctorID equals t4.DoctorID join
                  t5 in this.cc.Specilities on t4.SpecilityID equals t5.SpecilityID
                    select t;

            return v.ToList();

        }
    }
}
