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
    public class UserRepo : IUserRepo
    {
        CompanyContext cc;
        public UserRepo(CompanyContext cc)
        {
            this.cc = cc;
        }

        public LoginResultVM Signin(LoginVM rec)
        {
            LoginResultVM result = new LoginResultVM();
            var urec = this.cc.Users.SingleOrDefault(p => p.EmailID == rec.EmailID && p.Password == rec.Password);

            if (urec != null)
            {
                result.IsLoggedIn = true;
                result.LoggedInID = urec.UserID;
                result.LoggedInName = urec.FirstName;
            }
            else
            {
                result.IsLoggedIn = false;
            }
            return result;
        }

        public ResultVM Signup(UserVM rec)
        {
            ResultVM res = new ResultVM();
            try
            {
                User urec = new User();
                urec.FirstName = rec.FirstName;
                urec.LastName = rec.LastName;
                urec.EmailID = rec.EmailID;
                urec.Address = rec.Address;
                urec.MobileNo = rec.MobileNo;
                urec.Password = rec.Password;
                urec.CountryID = rec.CountryID;

                this.cc.Users.Add(urec);
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "User Registration Successfull!";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message.ToString();
            }
            return res;
        }
    
    }
}
