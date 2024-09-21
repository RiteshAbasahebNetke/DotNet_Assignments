using Microsoft.AspNetCore.Mvc;

namespace CustomAuthFilter.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
