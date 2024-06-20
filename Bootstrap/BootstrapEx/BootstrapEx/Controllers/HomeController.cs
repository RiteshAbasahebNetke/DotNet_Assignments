using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;

namespace BootstrapEx.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Grid()
        {
            return View();
        }

        public ActionResult Typography()
        {
            return View();
        }
        public ActionResult SomeComponents()
        {
            return View();
        }

        public ActionResult FewMoreComponents()
        {
            return View();
        }


        public ActionResult Tables()
        {
            return View();
        }

        public ActionResult Images()
        {
            return View();
        }

        public ActionResult Cards()
        {
            return View();
        }

        public ActionResult MarginPadding()
        {
            return View();
        }

        public ActionResult Forms()
        {
            return View();
        }

        public ActionResult Navigation()
        {
            return View();
        }

        public ActionResult Navbar()
        {
            return View();
        }

        public ActionResult Helpers()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}