using Model_Validation_Using_Data_Annotations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Model_Validation_Using_Data_Annotations.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer rec)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(rec);
        }
    }
}