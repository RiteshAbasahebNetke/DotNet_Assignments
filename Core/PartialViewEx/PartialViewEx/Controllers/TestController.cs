using Microsoft.AspNetCore.Mvc;
using PartialViewEx.Models;

namespace PartialViewEx.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            Emp e = new Emp();
            return View(e);
        }
    }
}
