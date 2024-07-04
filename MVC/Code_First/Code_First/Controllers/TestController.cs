using Code_First.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Code_First.Controllers
{
    public class TestController : Controller
    {
        CompanyContext cc = new CompanyContext();
        // GET: Test
        public ActionResult Index()
        {
            //return View(this.cc.Customers.ToList());
            var v = from m in this.cc.Customers
                    where m.Address == "Akurdi"
                    select m;
            return View(v.ToList());
        }
    }
}