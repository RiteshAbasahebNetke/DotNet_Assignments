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
    public class DoctorRepo:GenericRepo<Doctor>, IDoctorRepo
    {
        CompanyContext cc;
        public DoctorRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }
    }
}
