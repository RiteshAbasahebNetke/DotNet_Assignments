using Core;
using Entity.Repositories.Interfaces;
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

        public IEnumerable<DoctorRating> GetdrRatingID(long drid)
        {
            return this.cc.DoctorRatings.Where(p => p.DoctorID == drid).ToList();
        }
    }
}
