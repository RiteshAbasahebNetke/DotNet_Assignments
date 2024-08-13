using Core;
using Entity.Repositories.Interfaces;
using Entity.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class DoctorRatingVC : ViewComponent
    {
        IDoctorRepo drepo;
        IDoctorRatingRepo drrepo;
        public DoctorRatingVC(IDoctorRepo drepo,IDoctorRatingRepo drrepo)
        {
            this.drepo = drepo;
            this.drrepo = drrepo;
        }

        public IViewComponentResult Invoke(Int64 id)
        {
            var doctor=this.drepo.GetDoctor(id);
            var ratings=this.drrepo.GetdrRatingID(id);

            var v = new DoctorRatingVM
            {
                Doctor = doctor,
                Ratings = ratings,
            };

            return View(v);
        }
    }
}
