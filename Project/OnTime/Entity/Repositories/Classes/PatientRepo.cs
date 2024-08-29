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
    public class PatientRepo: GenericRepo<Patient>,IPatientRepo
    {
        CompanyContext cc;
        public PatientRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }

        public void Add(PatientVM rec)
        {
            Patient p=new Patient();
            p.FirstName = rec.FirstName;
            p.LastName= rec.LastName;
            p.Address = rec.Address;
            p.Gender=rec.Gender;
            p.EmailID = rec.EmailID;
            p.Password = rec.Password;
            p.PatientPhoto=rec.PatientPhoto;
            p.PhotoPath = rec.PhotoPath;
            p.MobileNo = rec.MobileNo;
            p.UserID = rec.UserID;

            this.cc.Patients.Add(p);
            this.cc.SaveChanges();  
        }
    }
}
