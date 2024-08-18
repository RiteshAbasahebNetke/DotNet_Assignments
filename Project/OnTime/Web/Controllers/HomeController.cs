using Core;
using Entity.Repositories.Classes;
using Entity.Repositories.Interfaces;
using Entity.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Web.CustAuthFilters;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        ICountryRepo crepo;
        ISpecilityRepo sprepo;
        IStateRepo srepo;
        ICityRepo ctrepo;
        IDoctorRepo drepo;
        IDoctorRatingRepo drrepo;
        public HomeController(ICountryRepo crepo, ISpecilityRepo sprepo,IStateRepo srepo, ICityRepo ctrepo, IDoctorRepo drepo, IDoctorRatingRepo drrepo)
        {
            this.crepo = crepo;
            this.sprepo = sprepo;
            this.srepo = srepo;
            this.ctrepo = ctrepo;
            this.drepo = drepo;
            this.drrepo = drrepo;
        }

        public IActionResult Index(Doctor rec, Int64 CountryID = 0, Int64 StateID = 0, Int64 CityID = 0, Int64 SpecilityID = 0)
        {
            ViewBag.CountryID = new SelectList(this.crepo.GetAll(), "CountryID", "CountryName");
            ViewBag.StateID = new SelectList(this.srepo.GetAll(), "StateID", "StateName");
            ViewBag.CityID = new SelectList(this.ctrepo.GetAll(), "CityID", "CityName");
            ViewBag.SpecilityID = new SelectList(this.sprepo.GetAll(), "SpecilityID", "SpecilityName");
            return View();
        }
        
        [HttpGet]
        public IActionResult Search(Doctor rec, Int64 CountryID = 0, Int64 StateID = 0, Int64 CityID = 0, Int64 SpecilityID = 0)
        {
            ViewBag.CountryID = new SelectList(this.crepo.GetAll(), "CountryID", "CountryName");
            ViewBag.SpecilityID = new SelectList(this.sprepo.GetAll(), "SpecilityID", "SpecilityName");

            if (CountryID > 0 || StateID > 0 || CityID > 0 || SpecilityID > 0)
            {
                return View(this.drepo.GetDoctors(CountryID,StateID,CityID,SpecilityID));
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddDRating(Int64 did, Int64 uid)
        {
            ViewBag.DoctorID = new SelectList(this.drepo.GetAll(), "DoctorID", "FullName");
            var rec=this.drepo.GetDoctorForRate(did);
            var ratings=this.drrepo.GetRatingsByDoctorID(did);
            DoctorRatingVM dm = new DoctorRatingVM();
            ViewBag.DoctorID = rec.DoctorID;
            //var m = new DoctorRatingVM
            //{
            //    Doctor = rec,
            //    UserID = uid
            //};
            return View(rec);
        }

        [HttpPost]
        public IActionResult AddDRating(Int64 did)
        {
            var doctorRating = new DoctorRating
            {
                DoctorID = did,
                //UserID = uid,
                //DoctorRatingID = ddid
            };
            this.drrepo.Add(doctorRating);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult ClinicView()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ClinicView(Clinic rec)
        {
            return View();
        }
    }

}

