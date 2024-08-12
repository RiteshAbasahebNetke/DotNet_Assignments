using Core;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repositories.Interfaces
{
    public interface IUserRepo
    {
        LoginResultVM Signin(LoginVM rec);
        ResultVM Signup(UserVM rec);
        ResultVM ChangePassword(ChangePasswordVM rec, Int64 userid);
        ResultVM EditProfile(EditProfileVM rec, Int64 userid);
        EditProfileVM GetByID(Int64 userid);
        User GetUserByID(Int64 uid);
    }
}
