using Microsoft.AspNetCore.Mvc;
using ViewCompEx.Models;

namespace ViewCompEx.ViewComponents
{
    public class ProductVC:ViewComponent
    {
        VContext vc;
        public ProductVC(VContext vc)
        {
            this.vc = vc;
        }
        public IViewComponentResult Invoke()
        {
            var rec = this.vc.Products.Single(p=>p.MfgName=="Dell");
            return View(rec);
        }
    }
}
