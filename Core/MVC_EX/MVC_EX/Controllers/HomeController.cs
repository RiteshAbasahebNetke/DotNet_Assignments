using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;

namespace MVC_EX.Controllers
{
    public class HomeController:Controller
    {
        public string Index()
        {
            return "Home Index Called..!";
        }
        public string SayHello()
        {
            return "SayHello Called..!";
        }
        public ActionResult GetView()
        {
            return View();
        }
    }
}
