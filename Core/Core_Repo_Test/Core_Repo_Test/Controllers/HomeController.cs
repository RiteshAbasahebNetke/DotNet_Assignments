using Core_Repo_Test.Models;
using Core_Repo_Test.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Core_Repo_Test.Controllers
{
    public class HomeController : Controller
    {
        IFlightRepo frepo;
        ICityRepo crepo;
        public HomeController(IFlightRepo frepo, ICityRepo crepo)
        {
            this.frepo = frepo;
            this.crepo = crepo;
        }
        public IActionResult Index()
        {
            
            return View(this.frepo.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.City = new SelectList(this.crepo.GetCities(), "CityID", "CityName");
            ViewBag.CityID= new SelectList(this.crepo.GetCities(), "CityID", "CityName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Flights rec)
        {
            this.frepo.Add(rec);
            return RedirectToAction("Index");
        }
    }
}
