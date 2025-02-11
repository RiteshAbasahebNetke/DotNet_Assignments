using CoreExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreExample.Controllers
{
    public class HomeController : Controller
    {
        Context c;
        public HomeController(Context c)
        {
            this.c = c;
        }
        public IActionResult Index()
        {
            return View(this.c.Products.ToList());
        }
    }
}
