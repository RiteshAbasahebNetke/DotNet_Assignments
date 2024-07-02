using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelBindingEX.Models;
namespace ModelBindingEX.Controllers
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
        public ActionResult Create([Bind (Exclude="EmailId,CustomerId")]Customer rec)
        {
            return RedirectToAction("Create");
        }
    }
}