using Core;
using Entity.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repositories.Classes
{
    public class CountryRepo:GenericRepo<Country>,ICountryRepo
    {
        CompanyContext cc;
        public CountryRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }
        public List<Doctor> GetCountry(long CountryID)
        {
            var v = from t in this.cc.Doctors join
                    t1 in this.cc.Areas on t.AreaID equals t1.AreaID join
                  t2 in this.cc.Cities on t1.CityID equals t2.CityID join
                  t3 in this.cc.States on t2.StateID equals t3.StateID join
                  t4 in this.cc.Countries on t3.CountryID equals t4.CountryID join
                  t5 in this.cc.DoctorSpecialities on t.DoctorID equals t5.DoctorID join
                  t6 in this.cc.Specilities on t5.SpecilityID equals t6.SpecilityID
                    select t;

            return v.ToList();

        }
    }
}
