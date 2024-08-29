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
    public class UserRepo : GenericRepo<User> ,IUserRepo
    {
        CompanyContext cc;
        public UserRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }

        public ResultVM ChangePassword(ChangePasswordVM rec, long userid)
        {
            ResultVM res = new ResultVM();
            var urec = this.cc.Users.Find(userid);
            if (urec != null)
            {
                if (urec.Password == rec.OldPassword)
                {
                    urec.Password = rec.NewPassword;
                    this.cc.SaveChanges();
                    res.IsSuccess = true;
                    res.Message = "Password Changed Successfully!!!";
                }
                else
                {
                    res.IsSuccess = false;
                    res.Message = "Invalid Old Password!";
                }
            }
            else
            {
                res.IsSuccess = false;
                res.Message = "Invalid User!";
            }

            return res;
        }

        public ResultVM EditProfile(EditProfileVM rec, Int64 userid)
        {
            ResultVM res = new ResultVM();
            try
            {
                var oldrec = this.cc.Users.Find(userid);
                oldrec.LastName = rec.LastName;
                oldrec.Address = rec.Address;
                oldrec.MobileNo = rec.MobileNo;
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Profile Updated Changed!";
            }
            catch (Exception ex)
            {
                res.Message = ex.Message.ToString();
            }

            return res;
        }

        public EditProfileVM GetByID(long userid)
        {
            var v = from t in this.cc.Users
                    where t.UserID == userid
                    select new EditProfileVM
                    {
                        Address = t.Address,
                        FirstName = t.FirstName,
                        LastName = t.LastName,
                        MobileNo = t.MobileNo,
                        EmailID = t.EmailID
                    };

            return v.FirstOrDefault();
        }

        public User GetUserByID(long uid)
        {
            return this.cc.Users.Find(uid);
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
