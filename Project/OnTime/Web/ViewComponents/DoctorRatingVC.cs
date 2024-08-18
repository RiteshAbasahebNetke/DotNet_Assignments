using Core;
using Entity.Repositories.Interfaces;
using Entity.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.ViewComponents
{
    public class DoctorRatingVC : ViewComponent
    {
        IDoctorRepo drepo;
        IDoctorRatingRepo drrepo;
        IUserRepo urepo;
        public DoctorRatingVC(IDoctorRepo drepo,IDoctorRatingRepo drrepo, IUserRepo urepo)
        {
            this.drepo = drepo;
            this.drrepo = drrepo;
            this.urepo = urepo;
        }

        public IViewComponentResult Invoke(Int64 did, Int64 uid)
        {
            ViewBag.DoctorID = new SelectList(this.drepo.GetAll(), "DoctorID", "FullName");
            ViewBag.DoctorID = did;
            var doctor = this.drepo.GetDoctorForRate(did);
            var ratings = this.drrepo.GetRatingsByDoctorID(did)
                            .Select(p => new DoctorRatingVM
                            {
                                FullName = this.urepo.GetUserByID(p.UserID).FullName,
                                //Rating = p.Rating
                            }).ToList();
                     
            var v = new DoctorRatingVM
            {
                Doctor = this.drepo.GetDoctorForRate(did),
                UserID = uid,
                //Ratings = ratings
            };

            return View(v);
        }
    }
}
