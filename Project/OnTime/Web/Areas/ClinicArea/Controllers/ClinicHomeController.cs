using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.ClinicArea.Controllers
{
    [Area("ClinicArea")]
    public class ClinicHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
