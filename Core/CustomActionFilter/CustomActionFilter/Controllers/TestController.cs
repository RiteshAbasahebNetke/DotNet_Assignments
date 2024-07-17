using Microsoft.AspNetCore.Mvc;

namespace CustomActionFilter.Controllers
{
    public class TestController : Controller
    {
        public IActionResult SayHello()
        {
            return View();
        }
    }
}
