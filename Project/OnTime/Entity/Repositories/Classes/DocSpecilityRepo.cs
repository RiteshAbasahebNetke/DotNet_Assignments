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
    public class DocSpecilityRepo : GenericRepo<DoctorSpeciality>, IDocSpecilityRepo
    {
        CompanyContext cc;
        public DocSpecilityRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }

        public ResultVM Add(DocSpecilityVM rec)
        {
            ResultVM res = new ResultVM();
            try
            {
                DoctorSpeciality dsr = new DoctorSpeciality();
                dsr.DoctorSpecilityID = rec.DoctorSpecilityID;
                dsr.DoctorID = rec.DoctorID;
                dsr.SpecilityID = rec.SpecilityID;

                Doctor d = new Doctor();
                d.FirstName = rec.FirstName;
                d.LastName=rec.LastName;
                d.MobileNo = rec.MobileNo;
                d.IsAvailable= rec.IsAvailable;
                d.Address=rec.Address;
                d.DoctorExperience=rec.DoctorExperience;
                d.Area.AreaName=rec.AreaName;
                d.PhotoPath = rec.PhotoPath;
                d.DoctorQualification=rec.DoctorQualification;
                d.Password = rec.Password;

                this.cc.DoctorSpecialities.Add(dsr);
                this.cc.Doctors.Add(d);
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Data added Successful";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message;
            }
            return res;
        }
    }
}
