using Core;
using Entity.Migrations;
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
        IClinicRepo crrepo;
        IClinicRatingRepo clrepo;
        IUserRepo urepo;
        public HomeController(ICountryRepo crepo, ISpecilityRepo sprepo,IStateRepo srepo, ICityRepo ctrepo, IDoctorRepo drepo, 
            IDoctorRatingRepo drrepo,IClinicRepo crrepo,IClinicRatingRepo clrepo,IUserRepo urepo)
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

        //[UserAuth]
        [HttpGet]
        public IActionResult AddDRating(Int64 did, Int64 uid)
        {
            var doctor = drepo.GetDoctorForRate(did);
            var ratings = drrepo.GetRatingsByDoctorID(did);
            var user = urepo.GetUserByID(uid);

            var drvm = new DoctorRatingVM()
            {
                Doctor = doctor,
                DoctorID = did,
                UserID = uid,
                FullName=user.FirstName,
                //Ratings=ratings
            };
            return View(drvm);
        }

        [HttpPost]
        public IActionResult AddDRating(DoctorRatingVM rec)
        {
            if (ModelState.IsValid)
            {
                drrepo.Add(rec);
                return RedirectToAction("AddDRating", new { did = rec.DoctorID, uid = rec.UserID });
            }
            var doctor = drepo.GetDoctorForRate(rec.DoctorID);
            var ratings = drrepo.GetRatingsByDoctorID(rec.DoctorID);
            rec.Doctor = doctor;
            rec.Ratings = ratings;
            return View(rec);
        }

        [HttpGet]
        public IActionResult ClinicView(Int64 cid)
        {
            var cvm = new ClinicVM { ClinicID = cid };
            this.crrepo.ClinicDetails(cvm);
            return View(cvm);
        }

        //[UserAuth]
        [HttpGet]
        public IActionResult AddClinicRating(Int64 cid)
        {
            var crvm = new ClinicRatingVM
            {
                ClinicID = cid,
                Ratings = this.clrepo.GetRatingsByClinicID(cid),
                FullName = HttpContext.Session.GetString("FirstName")
            };

            if (HttpContext.Session.GetString("UserID") == null)
            {
                return RedirectToAction("Login", "ManageUser");
            }
            return View(crvm);
        }

        [HttpPost]
        public IActionResult AddClinicRating(ClinicRatingVM rec)
        {
            //this.clrepo.Add(rec);
            return View();
        }

        //[HttpGet]
        //public IActionResult BookAppointment()
        //{
        //    return View();
        //}

    }

}

