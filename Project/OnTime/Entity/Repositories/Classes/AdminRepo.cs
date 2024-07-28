using Entity.Repositories.Interfaces;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repositories.Classes
{
    public class AdminRepo : IAdminRepo
    {
        CompanyContext cc;
        public AdminRepo(CompanyContext cc)
        {
            this.cc = cc;
        }
        public ResultVM ChangePassword(ChangePasswordVM rec, long adminid)
        {
            ResultVM res = new ResultVM();
            var arec = this.cc.Admins.Find(adminid);
            if(arec != null)
            {
                if(arec.Password ==rec.OldPassword)
                {
                    arec.Password=rec.NewPassword;
                    this.cc.SaveChanges();
                    res.IsSuccess = true;
                    res.Message = "Password Changed Successfully..!";
                }
                else
                {
                    res.IsSuccess = false;
                    res.Message = "Invalid Old Password";
                }
            }
            else
            {
                res.IsSuccess = false;
                res.Message = "Invalid User!";
            }
            return res;
        }

        public LoginResultVM Login(LoginVM rec)
        {
            LoginResultVM re = new LoginResultVM();
            var arec = this.cc.Admins.SingleOrDefault(p => p.EmailID == rec.EmailID && p.Password == rec.Password);

            if(arec!=null)
            {
                re.IsLoggedIn = true;
                re.LoggedInID = arec.AdminID;
                re.LoggedInName = arec.FullName;
            }
            else
            {
                re.IsLoggedIn=false;
            }
            return re;
        }
    }
}
