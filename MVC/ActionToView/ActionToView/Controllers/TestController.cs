using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActionToView.Models;

namespace ActionToView.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            Model m = new Model();
            return View(m);
        }
        public ActionResult GetProducts()
        {
            var v = Products.GetProducts();
            return View(v);
        }

        public ActionResult Product()
        {
            ViewBag.ProductId = 121;
            ViewBag.ProductName = "Monitor";
            ViewBag.MfgName = "Intex";
            ViewBag.Price = 25000;
            // return View();
            return RedirectToAction("GetViewBag");
        }
        public ActionResult GetviewBag()
        {
            return View();
        }
        public ActionResult ShowInfo()
        {
            ViewData["ProductId"] = 123;
            ViewData["ProductName"] = "Washing Machine";
            ViewData["MfgName"] = "Haier";
            ViewData["Price"] = 46000;
            //return View();
            return RedirectToAction("GetShowInfo");
        }
        public ActionResult GetShowInfo()
        {
            return View();
        }
        public ActionResult BookInfo()
        {
            TempData["BookId"] = 856;
            TempData["BookName"] = "India";
            TempData["AuthorName"] = "ABC";
            TempData["Price"] = 890;
            //return View();
            return RedirectToAction("GetBookInfo");
        }
        public ActionResult GetBookInfo()
        {
            return View();
        }
    }
}