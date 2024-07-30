using Entity.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class DoctorSpecilityCheckBoxListVC:ViewComponent
    {
        IDocSpecialityRepo dsrepo;
        public DoctorSpecilityCheckBoxListVC(IDocSpecialityRepo dsrepo)
        {
            this.dsrepo = dsrepo;
        }
        //public IViewComponentResult Invoke(Int64 DID=0)
        //{
        //    var allspecility = this.dsrepo.GetAll(DID);
        //        return View(allspecility);
        //}
    }
}
