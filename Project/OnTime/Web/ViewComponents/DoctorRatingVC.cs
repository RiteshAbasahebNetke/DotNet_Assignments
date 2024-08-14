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

        public IViewComponentResult Invoke(Int64 did)
        {
            var doctor=this.drepo.GetDoctor(did);

            var v = new DoctorRatingVM
            {
                Doctor = doctor,
            };

            return View(v);
        }
    }
}
