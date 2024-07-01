using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Views.Models;


namespace Views.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.ProductId = 1;
            ViewBag.ProductName = "Laptop";
            ViewBag.MfgName = "Dell";
            ViewBag.Price = 85000;
            // return View();

            return RedirectToAction("ShowPro");
        }

        public ActionResult ShowPro()
        {
            return View();
        }

        public ActionResult Show()
        {
            ViewData["EmpId"] = 1;
            ViewData["EmpName"] = "Raju";
            ViewData["DeptName"] = "Purchase";
            ViewData["Salary"] = 85411;
            // return View();
            return RedirectToAction("Showemp");
        }
        public ActionResult Showemp()
        {
            return View();
        }

        public ActionResult Project()
        {
            TempData["ProjectId"] = 23;
            TempData["ProjectName"] = "Air";
            TempData["ProjectArea"] = "Nagar";
            TempData["Budget"] = "6Cr";
            // return View();
            return RedirectToAction("Showproject");
        }
        public ActionResult Showproject()
        {
            return View();
        }

        public ActionResult Model()
        {
            Emp e = new Emp();
            return View(e);
        }

        public ActionResult GetProduct()
        {
            var v = new Product();
            return View();
        }
    }
}