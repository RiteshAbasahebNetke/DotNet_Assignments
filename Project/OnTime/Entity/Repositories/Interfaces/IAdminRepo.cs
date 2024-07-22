using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repositories.Interfaces
{
    public  interface IAdminRepo
    {
        LoginResultVM Login(LoginVM rec);
        ResultVM ChangePassword(ChangePasswordVM rec, Int64 adminid);
    }
}
