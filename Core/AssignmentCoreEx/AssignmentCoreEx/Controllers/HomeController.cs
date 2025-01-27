using Microsoft.AspNetCore.Mvc;

namespace AssignmentCoreEx.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
