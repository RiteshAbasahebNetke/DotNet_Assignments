using CustomAuthorizeFilter.Models;
using CustomAuthorizeFilter.Repositories.Interface;
using CustomAuthorizeFilter.ViewModel;

namespace CustomAuthorizeFilter.Repositories.Classes
{
    public class UserRepo : IUserRepo
    {
        Context cc;
        public UserRepo(Context cc)
        {
            this.cc = cc;
        }
        public LoginResultVM Login(LoginVM rec)
        {
            var urec = this.cc.Users.SingleOrDefault(p => p.EmailID == rec.EmailID && p.Password == rec.Password);
            LoginResultVM res=new LoginResultVM();
            if (urec != null)
            {
                res.IsLoggedIn = true;
                res.LoggedInName = urec.FullName;
                res.LoggedInID = urec.UserID;
            }
            else
            {
                res.IsLoggedIn = false;
            }
            return res;
        }

        public void Register(User rec)
        {
            this.cc.Add(rec);
            this.cc.SaveChanges();
        }
    }
}
