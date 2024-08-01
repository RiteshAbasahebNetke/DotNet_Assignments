using Entity.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class SpecilityCheckBoxListVC:ViewComponent
    {
        ISpecilityRepo srepo;
        public SpecilityCheckBoxListVC(ISpecilityRepo srepo)
        {
            this.srepo = srepo;
        }
        public IViewComponentResult Invoke(Int64 doctorid = 0)
        {
            var docsp = this.srepo.GetAllSpecilityWithSelection(doctorid);
            return View(docsp);
        }
    }
}
