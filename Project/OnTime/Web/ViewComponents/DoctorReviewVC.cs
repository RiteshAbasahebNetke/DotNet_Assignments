using Entity.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class DoctorReviewVC:ViewComponent
    {
        IDoctorRatingRepo drrepo;
        IUserRepo urepo;
        public DoctorReviewVC(IDoctorRatingRepo drrepo, IUserRepo urepo)
        {
            this.drrepo = drrepo;
            this.urepo = urepo;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
