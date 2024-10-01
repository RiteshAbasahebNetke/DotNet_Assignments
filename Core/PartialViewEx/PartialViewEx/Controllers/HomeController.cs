using Microsoft.AspNetCore.Mvc;
using PartialViewEx.Models;

namespace PartialViewEx.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Emp e=new Emp();
            return View(e);
        }
    }
}
