using Microsoft.AspNetCore.Mvc;

namespace ExceptionHandlingEx.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public int DoDivision(int a, int b)
        {
            return a / b;
        }
    }
}
