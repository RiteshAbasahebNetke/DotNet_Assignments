﻿using Core;
using Entity.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repositories.Classes
{
    public class DocSpecialityRepo: GenericRepo<DoctorSpeciality>, IDocSpecialityRepo
    {
        CompanyContext cc;
        public DocSpecialityRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }
    }
}
