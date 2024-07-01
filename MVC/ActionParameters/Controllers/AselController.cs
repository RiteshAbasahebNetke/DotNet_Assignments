using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionParameters.Controllers
{
    public class AselController : Controller
    {
        // GET: Asel

        [ActionName("cal")]
       public string CalculateValueUsingBinaryGussianDistribution()
        {
            return "Value Calculated";
        }
        [NonAction]
        public string SayHello()
        {
            return "Say Hello Called..!";
        }

        [HttpGet]
        public string foo(string id)
        {
            return "Foo Action Called...!";
        }
        public string foo()
        {
            return "Foo2 action called...";
        }
    }
}