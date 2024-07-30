using Entity.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.ClinicArea.Controllers
{
    [Area("ClinicArea")]
    public class ClinicHomeController : Controller
    {
        IClinicRepo crepo;
        public ClinicHomeController(IClinicRepo crepo)
        {
            this.crepo = crepo;
        }

        public IActionResult Index()
        {
            return View(this.crepo.GetAll());
        }

    }
}
