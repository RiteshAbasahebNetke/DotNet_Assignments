using EFCore_EX.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EFCore_EX.Controllers
{
    public class HomeController : Controller
    {
        CompanyContext cc;
        public HomeController(CompanyContext cc)
        {
            this.cc = cc;
        }
        public IActionResult Index()
        {
            return View(this.cc.Products.ToList());
        }
    }
}
