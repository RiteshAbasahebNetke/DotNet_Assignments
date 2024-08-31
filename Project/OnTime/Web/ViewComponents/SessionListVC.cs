using Entity.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.ViewComponents
{
    public class SessionListVC : ViewComponent
    {
        IDoctorClinicSessionRepo dcrepo;
        IOPDSessionRepo orepo;
        public SessionListVC(IDoctorClinicSessionRepo dcrepo,IOPDSessionRepo orepo)
        {
            this.orepo= orepo;
            this.dcrepo = dcrepo;
        }
        public IViewComponentResult Invoke(Int32 ID)
        {
            
            if(ID == 0)
            {
                ViewBag.Flag = 0;
                return View();
            }
            else
            {
                ViewBag.Flag = 1;
                var res = (this.dcrepo.GetAll().Where(p=>p.OpdSessionID== ID));
                return View(res);
            }
            return View();
        }
    }
}
