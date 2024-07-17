using Microsoft.AspNetCore.Mvc;
using ViewCompEx.Models;

namespace ViewCompEx.ViewComponents
{
    public class EmpVC:ViewComponent
    {
        VContext vc;
        public EmpVC(VContext vc)
        {
            this.vc = vc;
        }
        public IViewComponentResult Invoke()
        {
            var rec = this.vc.Emps.ToList();
            return View(rec);
        }
    }
}
