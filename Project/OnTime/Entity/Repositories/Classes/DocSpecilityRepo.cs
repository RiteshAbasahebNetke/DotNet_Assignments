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
    public class DocSpecilityRepo : GenericRepo<DoctorSpeciality>, IDocSpecilityRepo
    {
        CompanyContext cc;
        public DocSpecilityRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }

    }
}
