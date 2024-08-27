using Core;
using Entity.Repositories.Interfaces;
using Entity.ViewModels;
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

        public void Add(ClinicRatingVM rec)
        {
            ClinicRating cr = new ClinicRating();
            cr.Rating = rec.Rating;
            cr.Review = rec.Review;
            cr.UserID = rec.UserID;
            cr.ClinicID = rec.ClinicID;

            this.cc.ClinicRatings.Add(cr);
            this.cc.SaveChanges();
        }

        public List<ClinicRatingVM> GetRatingsByClinicID(long id)
        {
            var rec = from t in this.cc.ClinicRatings
                      where t.ClinicID == id
                      select new ClinicRatingVM
                      {
                          ClinicID = t.ClinicID,
                          UserID = t.UserID,
                          Rating = t.Rating,
                          Review = t.Review,
                          FirstName = t.User.FirstName
                      };
            return rec.ToList();
        }
    }
}
