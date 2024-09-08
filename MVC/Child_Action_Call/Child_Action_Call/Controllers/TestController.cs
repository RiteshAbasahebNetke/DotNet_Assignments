using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Child_Action_Call.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public string SayHello()
        {
            return "Say Hello Called..!";
        }
        public string SayBye()
        {
            return "Say Bye Called..!";
        }
        public PartialViewResult GetSample()
        {
            return PartialView("_Sample");
        }
        public PartialViewResult GetDemo()
        {
            return PartialView("_Demo");
        }
    }
}