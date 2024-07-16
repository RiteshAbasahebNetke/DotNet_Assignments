using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthorizeAllowAnyamous.Controllers
{
    [Authorize]
    public class TestController : Controller
    {
        //[Authorize]
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult About()
        {
            return View();
        }
        //[Authorize]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
