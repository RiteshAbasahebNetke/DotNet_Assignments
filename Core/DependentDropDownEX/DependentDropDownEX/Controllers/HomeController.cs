using DependentDropDownEX.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DependentDropDownEX.Controllers
{
    public class HomeController : Controller
    {
        CompanyContext cc;
        public HomeController(CompanyContext cc)
        {
            this.cc = cc;
        }

        public IActionResult Index()
        {
            ViewBag.CountryID = new SelectList(this.cc.Countries.ToList(), "CountryID", "CountryName");
            return View();
        }
        public IActionResult GetStates(Int64 id)
        {
            ViewBag.StateID = new SelectList(this.cc.States.ToList(), "StateID", "StateName");
            var res=this.cc.States.Where(p=>p.CountryID==id).ToList();
            return Json(res);
        }
        public IActionResult GetCities(Int64 id)
        {
            ViewBag.CityID = new SelectList(this.cc.Cities.ToList(), "CityID", "CityName");
            var res = this.cc.States.Where(p => p.StateID == id).ToList();
            return Json(res);
        }
    }
}
