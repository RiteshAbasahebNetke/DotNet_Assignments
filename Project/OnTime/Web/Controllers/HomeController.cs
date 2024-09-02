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
        IOPDSessionRepo orepo;
        IPatientRepo prepo;
        IWebHostEnvironment env;
        IBookedAppointmentsRepo barepo;
        IDoctorClinicSessionRepo dcrepo;
        public HomeController(ICountryRepo crepo, ISpecilityRepo sprepo,IStateRepo srepo, ICityRepo ctrepo, 
            IDoctorRepo drepo, IDoctorRatingRepo drrepo,IClinicRepo crrepo, IClinicRatingRepo clrepo, IUserRepo urepo, 
            IClinicFacilityRepo cfrepo, IOPDSessionRepo orepo, IPatientRepo prepo, 
            IWebHostEnvironment env,IBookedAppointmentsRepo barepo,IDoctorClinicSessionRepo dcrepo)
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
            this.orepo = orepo;
            this.prepo = prepo;
            this.env = env;
            this.barepo= barepo;
            this.dcrepo = dcrepo;
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

        [UserAuth]
        [HttpGet]
        public IActionResult BookAppointment()
        {
            ViewBag.OpdSessionID = new SelectList(this.orepo.GetAll(), "OpdSessionID", "SessionName");
            ViewBag.ID = 0;
            return View();
        }

        [HttpPost]
        public IActionResult BookAppointment(Int64 OpdSessionID)
        {
            ViewBag.OpdSessionID = new SelectList(this.orepo.GetAll(), "OpdSessionID", "SessionName");
            ViewBag.ID = Convert.ToInt32(OpdSessionID);
            return View();
        }

        [HttpGet]
        public IActionResult BookApp()
        {
            ViewBag.UserID = new SelectList(this.prepo.GetAll(), "FirstName", "UserID");
            return View(this.prepo.GetAll());
        }

        [HttpGet]
        public IActionResult AddPatient()
        {
            ViewBag.UserID = new SelectList(this.urepo.GetAll(), "UserID","FirstName");
            return View();
        }

        [HttpPost]
        public IActionResult AddPatient(PatientVM rec)
        {
            ViewBag.UserID = new SelectList(this.urepo.GetAll(), "UserID", "FirstName");
            if (ModelState.IsValid)
            {
                if (rec.PatientPhoto != null)
                {
                    if (rec.PatientPhoto.Length > 0)
                    {
                        string filename = rec.PatientPhoto.FileName;
                        string folderpath = Path.Combine(env.WebRootPath, "DoctorPhotos");
                        string actualfilepath = Path.Combine(folderpath, filename);
                        FileStream fs = new FileStream(actualfilepath, FileMode.Create);
                        rec.PatientPhoto.CopyTo(fs);
                        rec.PhotoPath = Path.Combine("\\DoctorPhotos", filename);
                    }
                }
                this.prepo.Add(rec);
                return RedirectToAction("BookApp",new {ViewBag.PatientID});
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Select(Int64 id)
        {
            ViewBag.DoctorClinicSessionID = new SelectList(this.dcrepo.GetAll(), "DoctorClinicSessionID","StartTime");
            var rec=this.prepo.GetByID(id);
            return View(rec);
        }

        public IActionResult Select(BookAppVM rec)
        {
            this.barepo.Add(rec);
            return View();
        }
    }
}

