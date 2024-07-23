using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.AdminArea.Controllers
{
    public class CityAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
