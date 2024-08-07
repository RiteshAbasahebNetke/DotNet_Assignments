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
        IStateRepo srepo;
        ICityRepo ctrepo;
        ISpecilityRepo sprepo;
        IDoctorRepo drepo;
        public HomeController(ICountryRepo crepo, ISpecilityRepo sprepo, IDoctorRepo drepo,ICityRepo ctrepo,IStateRepo srepo)
        {
            this.crepo = crepo;
            this.sprepo = sprepo;
            this.drepo = drepo;
            this.ctrepo = ctrepo;
            this.srepo = srepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Search(Int64 cname, Int64 spname)
        {

            if (cname != 0 && spname != 0)
            {
                ViewBag.CountryID = new SelectList(this.crepo.GetAll(), "CountryID", "CountryName");
                ViewBag.SpecilityID = new SelectList(this.sprepo.GetAll(), "SpecilityID", "SpecilityName");

                return View(this.crepo.GetCountry(cname,spname));
            }
            //else if(sname != 0 && spname != 0)
            //{
            //    ViewBag.StateID = new SelectList(this.srepo.GetAll(), "StateID", "StateName");
            //    ViewBag.SpecilityID = new SelectList(this.sprepo.GetAll(), "SpecilityID", "SpecilityName");

            //}
            //else if (ctname != 0 && spname != 0)
            //{
            //    ViewBag.CityID = new SelectList(this.ctrepo.GetAll(), "CityID", "CityName");
            //    ViewBag.SpecilityID = new SelectList(this.sprepo.GetAll(), "SpecilityID", "SpecilityName");
            //}
                return View();
        }
    }
}
