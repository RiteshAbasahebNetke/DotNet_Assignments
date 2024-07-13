using Microsoft.AspNetCore.Mvc;
using Repo_EX.Models;
using Repo_EX.Repositories;

namespace Repo_EX.Controllers
{
    public class HomeController : Controller
    {
        ProductRepo prepo;
        public HomeController()
        {
            this.prepo = new ProductRepo();
        }
        public IActionResult Index()
        {
            return View(this.prepo.GetProducts());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product rec)
        {
            this.prepo.AddProduct(rec);
            return RedirectToAction("Index");
        }
    }
}
