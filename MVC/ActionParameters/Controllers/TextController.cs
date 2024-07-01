using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionParameters.Controllers
{
    public class TextController : Controller
    {
        // GET: Text
       public string SayHello(String id, string str)
        {
            return "Value of Id is:" + id + "Value of str:" + str;
        }

        public string SayBye(int id = 0)
        {
            return "Value of ID is:" + id;
        }

        public int doAddtion(int a , int b)
        {
            return a + b;
        }
    }
}