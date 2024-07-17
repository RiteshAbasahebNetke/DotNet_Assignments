using Microsoft.AspNetCore.Mvc;
using PartialViewsEx.Models;

namespace PartialViewsEx.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Emp e = new Emp();
            return View(e);
        }
    }
}
