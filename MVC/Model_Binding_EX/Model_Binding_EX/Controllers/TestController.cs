using Model_Binding_EX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Model_Binding_EX.Controllers
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
        //public ActionResult Create([Bind(Include ="CustomerName, CreditLimit")]Customer rec)
        public ActionResult Create([Bind(Exclude ="EmailId,CreditLimit")] Customer rec)
        {
            return RedirectToAction("Index");
        }
    }
}