using Microsoft.AspNetCore.Mvc;
using ViewCompEx.Models;

namespace ViewCompEx.ViewComponents
{
    public class BookVC:ViewComponent
    {
        VContext vc;
        public BookVC(VContext vc)
        {
            this.vc = vc;
        }
        public IViewComponentResult Invoke()
        {
            var rec = this.vc.Books.FirstOrDefault();
            return View(rec);
        }
    }
}
