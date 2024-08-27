using Entity.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.ViewComponents
{
    public class ClinicRatingVC:ViewComponent
    {
        IClinicRepo crepo;
        IClinicRatingRepo clrepo;
        IUserRepo urepo;

        public ClinicRatingVC(IClinicRepo crepo, IClinicRatingRepo clrepo, IUserRepo urepo)
        {
            this.crepo = crepo;
            this.clrepo = clrepo;
            this.urepo = urepo;
        }

        public IViewComponentResult Invoke(Int64 cid, Int64 uid)
        {
            ViewBag.ClinicID = new SelectList(this.crepo.GetAll(), "ClinicID", "FullName");
            ViewBag.ClinicID = cid;
            var ratings = this.clrepo.GetRatingsByClinicID(cid).ToList();
            return View(ratings);
        }
    }
}
