using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace BuiltInFilters.Controllers
{
    public class TestController : Controller
    {
        [OutputCache(Duration=5)]
        public string GetDate()
        {
            return DateTime.Now.ToString();
        }
        [HandleError(View="_CustomLayout")]
        public int GetDivision(int a,int b)
        {
            return a / b;
        }
    }
}