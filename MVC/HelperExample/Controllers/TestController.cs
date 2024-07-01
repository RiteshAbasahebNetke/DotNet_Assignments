using HelperExample.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelperExample.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StandardHelpers()
        {
            return View();
        }

        public ActionResult StronglyTypedHelpers()
        {
            return View();  
        }


        public ActionResult TemplateHelper()
        {
            Customer c = new Customer();
            return View(c);
        }
    }
}