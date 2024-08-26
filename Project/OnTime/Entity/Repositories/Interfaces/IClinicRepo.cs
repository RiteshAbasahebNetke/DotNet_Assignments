using Core;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repositories.Interfaces
{
    public interface IClinicRepo 
    {
        LoginResultVM SignIn(LoginVM rec);
        ResultVM SignUp(ClinicVM rec);
        List<Clinic> GetAll();
        ClinicVM ClinicDetails(Int64 cid);
        Clinic GetClinic(Int64 aid);
        Clinic GetClinicForRate(Int64 cid);
    }
}
