using code_first_ex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace code_first_ex.Controllers
{
    public class TestController : Controller
    {
        CompanyContext cc = new CompanyContext();
        // GET: Test
        public ActionResult Index()
        {
            return View(this.cc.Emps.ToList());
        }
    }
}