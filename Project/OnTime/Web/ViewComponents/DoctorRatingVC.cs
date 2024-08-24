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
            var ratings = this.drrepo.GetRatingsByDoctorID(uid).ToList();
            return View(ratings);
        }
    }
}
