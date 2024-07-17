using CustomActionFilter.CusAuthFilters;
using Microsoft.AspNetCore.Mvc;

namespace CustomActionFilter.Controllers
{
    [LogFilter]
    public class HomeController : Controller
    {
        [LogFilter]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
