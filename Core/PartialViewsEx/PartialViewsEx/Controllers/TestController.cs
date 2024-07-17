using Microsoft.AspNetCore.Mvc;

namespace PartialViewsEx.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
