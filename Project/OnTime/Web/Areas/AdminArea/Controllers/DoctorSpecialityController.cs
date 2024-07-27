using Entity.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.AdminArea.Controllers
{
    public class DoctorSpecialityController : Controller
    {
        IDocSpecialityRepo dsrepo;
        ISpecilityRepo sprepo;
        public DoctorSpecialityController(IDocSpecialityRepo dsrepo, ISpecilityRepo sprepo)
        {
            this.dsrepo = dsrepo;
            this.sprepo = sprepo;
        }

        public IActionResult Index()
        {
            return View(this.dsrepo.GetAll());
        }
    }
}
