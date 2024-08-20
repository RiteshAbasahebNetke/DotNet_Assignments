using Entity.Repositories.Interfaces;
using Entity.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.ViewComponents
{
    public class DrClinicSessionVC:ViewComponent
    {
        IOPDSessionRepo orepo;
        IDoctorClinicSessionRepo drclrepo;

        public DrClinicSessionVC(IOPDSessionRepo orepo, IDoctorClinicSessionRepo drclrepo)
        {
            this.orepo = orepo;
            this.drclrepo = drclrepo;
        }

        public IViewComponentResult Invoke(DrClSessionVM rec)
        {
            ViewBag.OpdSessionID = new SelectList(this.orepo.GetAll(), "OpdSessionID", "SessionName");
            return View();
        }
    }
}
