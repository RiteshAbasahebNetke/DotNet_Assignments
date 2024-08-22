using Core;
using Entity.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repositories.Classes
{
    public class ClinicRatingRepo:GenericRepo<ClinicRating>,IClinicRatingRepo
    {
        CompanyContext cc;
        public ClinicRatingRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }
        //public void AddClinicRating(ClinicRating rating)
        //{
        //    this.cc.ClinicRatings.Add(rating);
        //    this.cc.SaveChanges();
        //}

        public IEnumerable<ClinicRating> GetRatingsByClinicID(long id)
        {
            return this.cc.ClinicRatings.Where(p => p.ClinicID == id)
               .Include(p => p.User).ToList();
        }
    }
}
