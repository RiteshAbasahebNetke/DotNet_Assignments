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
    public class DoctorRepo:GenericRepo<Doctor>, IDoctorRepo
    {
        CompanyContext cc;
        public DoctorRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }
        public void Add(DocSpecilityVM rec)
        {

            Doctor d = new Doctor();
            d.FirstName = rec.FirstName;
            d.LastName = rec.LastName;
            d.MobileNo = rec.MobileNo;
            d.IsAvailable = rec.IsAvailable;
            d.Address = rec.Address;
            d.DoctorExperience = rec.DoctorExperience;
            d.AreaID = rec.AreaID;
            d.PhotoPath = rec.PhotoPath;
            d.DoctorQualification = rec.DoctorQualification;
            d.Password = rec.Password;

            foreach (var temp in rec.Specilities)
            {
                DoctorSpeciality ds = new DoctorSpeciality();
                ds.SpecilityID = temp;
                d.DoctorSpecialities.Add(ds);
            }

            this.cc.Doctors.Add(d);
            this.cc.SaveChanges();
        }

    }
}
