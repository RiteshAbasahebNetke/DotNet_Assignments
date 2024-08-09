using Entity.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class ViewClinicVC:ViewComponent
    {
        IClinicRepo crepo;
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
