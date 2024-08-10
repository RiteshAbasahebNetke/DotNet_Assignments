using Core;
using Entity.Repositories.Interfaces;
using Entity.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        ICountryRepo crepo;
        ISpecilityRepo sprepo;
        public HomeController(ICountryRepo crepo, ISpecilityRepo sprepo)
        {
            this.crepo = crepo;
            this.sprepo = sprepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Search(Doctor rec, Int64 CountryID = 0, Int64 StateID = 0, Int64 CityID = 0, Int64 SpecilityID = 0)
        {

            ViewBag.CountryID = new SelectList(this.crepo.GetAll(), "CountryID", "CountryName");
            ViewBag.SpecilityID = new SelectList(this.sprepo.GetAll(), "SpecilityID", "SpecilityName");

            if (CountryID > 0 || StateID > 0 || CityID > 0 || SpecilityID > 0)
            {
                return View(this.crepo.GetCountry(CountryID));
            }
            return View();

        }

    }

}

