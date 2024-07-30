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
    public class ClinicRepo:IClinicRepo
    {
        CompanyContext cc;
        public ClinicRepo(CompanyContext cc)
        {
            this.cc = cc;
        }

        public List<Clinic> GetAll()
        {
            return this.cc.Clinics.ToList();
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
