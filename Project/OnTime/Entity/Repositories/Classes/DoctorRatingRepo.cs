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
    public class DoctorRatingRepo:GenericRepo<DoctorRating>,IDoctorRatingRepo
    {
        CompanyContext cc;
        public DoctorRatingRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }

        public void Add(DoctorRatingVM rec)
        {
            DoctorRating dr=new DoctorRating();
            dr.Rating = rec.Rating;
            dr.Review = rec.Review;
            dr.UserID = rec.UserID;
            dr.DoctorID=rec.DoctorID;

            this.cc.DoctorRatings.Add(dr);
            this.cc.SaveChanges();
        }

        public List<DoctorRatingVM> GetRatingsByDoctorID(long id)
        {
            //var rec = this.cc.DoctorRatings.Where(p => p.UserID == id).ToList();

            ////return this.cc.DoctorRatings.Where(p => p.UserID == id).ToList();
            //return rec;


            var rec = from t in this.cc.DoctorRatings
                      where t.UserID == id
                      select new DoctorRatingVM
                      {
                          DoctorID = t.DoctorID,
                          UserID = t.UserID,
                          Rating = t.Rating,
                          Review = t.Review,
                          FirstName=t.User.FirstName
                      };
            return rec.ToList();
        }
    }
}