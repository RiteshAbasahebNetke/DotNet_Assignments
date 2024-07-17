using CustomAuthorizeFilter.CustAuthFilter;
using Microsoft.AspNetCore.Mvc;

namespace CustomAuthorizeFilter.Controllers
{
    public class HomeController : Controller
    {
        [UserAuth]
        public IActionResult Index()
        {
            return View();
        }
    }
}
