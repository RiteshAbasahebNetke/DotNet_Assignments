using Core;
using Entity.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repositories.Classes
{
    public class CountryRepo:GenericRepo<Country>,ICountryRepo
    {
        CompanyContext cc;
        public CountryRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }
    }
}
