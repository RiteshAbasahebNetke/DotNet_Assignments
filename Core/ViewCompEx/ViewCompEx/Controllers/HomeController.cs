using Microsoft.AspNetCore.Mvc;

namespace ViewCompEx.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
