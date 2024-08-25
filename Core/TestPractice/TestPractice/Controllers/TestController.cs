using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace TestPractice.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public RedirectResult GoToGoogle()
        {
            return Redirect("https://www.google.com");
        }
        public RedirectToRouteResult GoToFoo()
        {
            // return RedirectToAction("Foo");
            return RedirectToAction ("SayHello", "ABCD", new { id = "Raj", str = "raj@hotmail.com" });
        }
        public string Foo()
        {
            return "Foo Action Called..!";
        }
        public ContentResult GetContent()
        {
            string str = "script type='text/javascript> alert('Hello')</script>";
            return Content(str,"text/javascript",Encoding.ASCII);
        }
        public EmptyResult GetEmpty()
        {
            // return null;
            return new EmptyResult();
        }
        public FileResult GetFile()
        {
            return File ("~/content/site.css", "text/css");
        }
        public JsonResult GetJson()
        {
            var rec = new { ProductId = 1, ProductName = "Monitor", MfgName = "Lenovo", Price = 520 };
            return Json(rec, JsonRequestBehavior.AllowGet);
        }
    }
}