using COREExamUsing5.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace COREExamUsing5.Controllers
{
    public class HomeController : Controller
    {
        Context cc;
        public HomeController(Context cc)
        {
            this.cc = cc;
        }

        public IActionResult Index()
        {
            return View(this.cc.Emps.ToList());
        }
    }
}
