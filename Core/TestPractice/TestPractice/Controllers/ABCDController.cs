using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestPractice.Controllers
{
    public class ABCDController : Controller
    {
        // GET: ABCD
        public ActionResult Index()
        {
            return View();
        }
        public string SayHello(string id,string str)
        {
            return "Say Hello Callled with Id:-" + id + "Say Hello Called with Str:-" + str;
        }
    }
}