using Core;
using Entity.Repositories.Interfaces;
using Entity.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repositories.Classes
{
    public class ClinicRepo:IClinicRepo
    {
        CompanyContext cc;
        public ClinicRepo(CompanyContext cc)
        {
            this.cc = cc;
        }

        public void ClinicDetails(ClinicVM rec)
        {
            var v = (from t in this.cc.Doctors
                     join t1 in this.cc.Areas on t.AreaID equals t1.AreaID
                     join t2 in this.cc.Cities on t1.CityID equals t2.CityID
                     join t3 in this.cc.Clinics on t2.CityID equals t3.CityID
                     select new ClinicVM
                     {
                         ClinicID = t3.ClinicID,
                         ClinicName = t3.ClinicName,
                         Address = t3.Address,
                         MobileNo = t3.MobileNo,
                         EmailID = t3.EmailID,
                         ContactPersonName = t3.ContactPersonName,
                         LandLineNo = t3.LandLineNo,
                         WebsiteUrl = t3.WebsiteUrl,
                         CityName = t3.City.CityName,
                         ClinicFacilities = t3.ClinicFacilities
                     });

            this.cc.SaveChanges();
        }

        public List<Clinic> GetAll()
        {
            return this.cc.Clinics.ToList();
        }

        public Clinic GetClinic(long aid)
        {
            var area=this.cc.Areas.Include(p=>p.CityID).FirstOrDefault(p=>p.AreaID==aid);
            return this.cc.Clinics.FirstOrDefault(p=>p.CityID==area.CityID);
        }

        public LoginResultVM SignIn(LoginVM rec)
        {
            LoginResultVM re = new LoginResultVM();
            var crec = this.cc.Clinics.SingleOrDefault(p => p.EmailID == rec.EmailID && p.Password == rec.Password);
            
            if(crec!=null)
            {
                re.IsLoggedIn = true;
                re.LoggedInID = crec.ClinicID;
                re.LoggedInName = crec.ClinicName;
            }
            else
            {
                re.IsLoggedIn=false;
            }
            return re;
        }

        public ResultVM SignUp(ClinicVM rec)
        {
            ResultVM res=new ResultVM();
            try
            {
                Clinic crec=new Clinic();
                crec.ClinicName= rec.ClinicName;
                crec.Address = rec.Address;
                crec.MobileNo = rec.MobileNo;
                crec.EmailID = rec.EmailID;
                crec.ContactPersonName = rec.ContactPersonName;
                crec.LandLineNo = rec.LandLineNo;
                crec.WebsiteUrl = rec.WebsiteUrl;
                crec.Password = rec.Password;
                crec.CityID = rec.CityID;

                this.cc.Clinics.Add(crec);
                this.cc.SaveChanges();
                res.IsSuccess= true;
                res.Message = "Sign Up for Clinic is Successful";
            }
            catch(Exception ex)
            {
                res.IsSuccess= false;
                res.Message = ex.Message;
            }
            return res;
        }
    }
}
