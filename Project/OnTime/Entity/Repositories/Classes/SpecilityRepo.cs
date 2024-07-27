using Core;
using Entity.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repositories.Classes
{
    public class SpecilityRepo : GenericRepo<Specility>, ISpecilityRepo
    {
        CompanyContext cc;
        public SpecilityRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }
    }
}
