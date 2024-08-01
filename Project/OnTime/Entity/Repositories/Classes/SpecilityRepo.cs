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
    public class SpecilityRepo : GenericRepo<Specility>, ISpecilityRepo
    {
        CompanyContext cc;
        public SpecilityRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }

        public List<CheckBoxVM> GetAllSpecilityWithSelection(long doctorId)
        {
            var docsp = this.cc.DoctorSpecialities.Where(p => p.DoctorID == doctorId);

            var v = from t in this.cc.Specilities
                    select new CheckBoxVM
                    {
                        Text = t.SpecilityName,
                        Value = t.SpecilityID,
                        IsSelected = docsp.Any(p => p.SpecilityID == t.SpecilityID) ? true : false
                    };
            return v.ToList();
        }
    }
}
