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
    }
}
