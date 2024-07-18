using Microsoft.AspNetCore.Mvc;

namespace EnviornmentVariable.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
