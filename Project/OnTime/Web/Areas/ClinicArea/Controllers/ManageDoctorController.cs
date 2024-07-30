using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.ClinicArea.Controllers
{
    [Area("ClinicArea")]
    public class ManageDoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
