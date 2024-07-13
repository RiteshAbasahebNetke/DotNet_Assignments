using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TagHelpersEX.Models;

namespace TagHelpersEX.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.ct = new SelectList(City.GetAllCities(), "CityID", "CityName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer rec)
        {
            return RedirectToAction("Index");
        }
    }
}
