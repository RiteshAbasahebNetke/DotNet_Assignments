using CascadingUsingAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CascadingUsingAjax.Controllers
{
    public class TestController : Controller
    {
        CompanyContext cc=new CompanyContext();
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.CountryID = new SelectList(this.cc.Countries.ToList(), "CountryID", "CountryName");
            return View();
        }

        public ActionResult GetStates(Int64 id)
        {
            var res = this.cc.States.Where(p => p.CountryID == id).ToList();
            return View();
        }
        public ActionResult GetCities(Int64 id)
        {
            var res = this.cc.Cities.Where(p => p.StateID == id).ToList();
            return View();
        }
    }
}