using AntiforgeryToken.Models;
using Microsoft.AspNetCore.Mvc;

namespace AntiforgeryToken.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class HomeController : Controller
    {
        //[ValidateAntiForgeryToken]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        //[IgnoreAntiforgeryToken]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product rec)
        {
            return RedirectToAction("Index"); 
        }
    }
}
