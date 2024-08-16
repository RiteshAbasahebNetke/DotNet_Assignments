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
    public class DoctorRatingRepo:GenericRepo<DoctorRating>,IDoctorRatingRepo
    {
        CompanyContext cc;
        public DoctorRatingRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }

        public void AddRating(DoctorRating rating)
        {
            this.cc.DoctorRatings.Add(rating);
            this.cc.SaveChanges();
        }

        public IEnumerable<DoctorRating> GetRatingsByDoctorID(long id)
        {
            return this.cc.DoctorRatings.Where(p => p.DoctorID == id)
                .Include(p => p.User).ToList();
        }
    }
}