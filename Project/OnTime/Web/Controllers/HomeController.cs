using Core;
using Entity.Migrations;
using Entity.Repositories.Classes;
using Entity.Repositories.Interfaces;
using Entity.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using System.Security.Cryptography;
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
        IClinicRepo crrepo;
        IClinicRatingRepo clrepo;
        IUserRepo urepo;
        IClinicFacilityRepo cfrepo;
        public HomeController(ICountryRepo crepo, ISpecilityRepo sprepo,IStateRepo srepo, ICityRepo ctrepo, IDoctorRepo drepo, 
            IDoctorRatingRepo drrepo,IClinicRepo crrepo,IClinicRatingRepo clrepo,IUserRepo urepo,IClinicFacilityRepo cfrepo)
        {
            this.crepo = crepo;
            this.sprepo = sprepo;
            this.srepo = srepo;
            this.ctrepo = ctrepo;
            this.drepo = drepo;
            this.drrepo = drrepo;
            this.crrepo = crrepo;
            this.clrepo = clrepo;
            this.urepo = urepo;
            this.cfrepo = cfrepo;
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

        [UserAuth]
        [HttpGet]
        public IActionResult AddDRating(Int64 did, Int64 uid)
        {
            ViewBag.did = did;
            ViewBag.uid= Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            return View();
        }

        [HttpPost]
        public IActionResult AddDRating(DoctorRating rec)
        {
            ViewBag.did = rec.DoctorID;
            ViewBag.uid = rec.UserID;
            if (ModelState.IsValid)
            {
                drrepo.Add(rec);
                return RedirectToAction("AddDRating");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult ClinicView(Int64 cid)
        {
            ViewBag.cid = cid;
            ViewBag.uid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            var rec=this.crrepo.ClinicDetails(cid);
            return View(rec);
        }

        [UserAuth]
        [HttpGet]
        public IActionResult AddClinicRating(Int64 cid, Int64 uid)
        {
            ViewBag.cid = cid;
            ViewBag.uid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            return View();
        }

        [HttpPost]
        public IActionResult AddClinicRating(ClinicRating rec)
        {
            ViewBag.cid = rec.ClinicID;
            ViewBag.uid = rec.UserID;
            if (ModelState.IsValid)
            {
                clrepo.Add(rec);
                return RedirectToAction("AddClinicRating");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult BookAppointment()
        {
            return View();
        }

    }

}

