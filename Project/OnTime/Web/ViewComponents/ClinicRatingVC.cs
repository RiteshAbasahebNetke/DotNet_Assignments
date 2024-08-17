using Entity.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class ClinicRatingVC:ViewComponent
    {
        IClinicRatingRepo crrepo;
        IClinicRepo crepo;
        IUserRepo urepo;

        public ClinicRatingVC(IClinicRatingRepo crrepo, IClinicRepo crepo, IUserRepo urepo)
        {
            this.crrepo = crrepo;
            this.crepo = crepo;
            this.urepo = urepo;
        }
        public IViewComponentResult Invoke(Int64 cid, Int64 uid)
        {
            return View();
        }
    }
}
