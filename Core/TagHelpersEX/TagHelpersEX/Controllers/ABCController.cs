using Microsoft.AspNetCore.Mvc;
using TagHelpersEX.Models;

namespace TagHelpersEX.Controllers
{
    public class ABCController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string SayHello(string str, string id)
        {
            return "String str:" + str + "string Id:" + id;
        }
        [HttpPost]
        public IActionResult Save(Customer rec)
        {
            return View(); 
        }
        
    }
}
