﻿using Entity.Repositories.Interfaces;
using Entity.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Controllers
{
    public class ManageClinicController : Controller
    {
        IClinicRepo crepo;
        ICityRepo ctrepo;
        public ManageClinicController(IClinicRepo crepo)
        {
            this.crepo = crepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(LoginVM rec)
        {
            if (ModelState.IsValid)
            {
                var res = this.crepo.SignIn(rec);
                if (res.IsLoggedIn)
                {
                    HttpContext.Session.SetString("ClinicID", res.LoggedInID.ToString());
                    HttpContext.Session.SetString("ClinicName", res.LoggedInName);

                    return RedirectToAction("Index", "ManageClinic");
                }
                ModelState.AddModelError("", "Invalid EmailID or Password");
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(ClinicVM rec)
        {
            if(ModelState.IsValid)
            {
                var res = this.crepo.SignUp(rec);
                if(res.IsSuccess)
                {
                    return RedirectToAction("SignIn");
                }
                ModelState.AddModelError("", res.Message);
            }
            //ViewBag.CityID = new SelectList(this.ctrepo.GetAll(), "CityID", "CityName");
            return View(rec);
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View();
        }
    }
}