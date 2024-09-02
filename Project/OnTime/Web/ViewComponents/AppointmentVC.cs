using Core;
using Entity.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.ViewComponents
{
    public class AppointmentVC:ViewComponent
    {
        IOPDSessionRepo orepo;
        public AppointmentVC(IOPDSessionRepo orepo)
        {
            this.orepo = orepo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.OpdSessionID = new SelectList(this.orepo.GetAll(), "OpdSessionID", "SessionName");
            return View();
        }
    }
}
