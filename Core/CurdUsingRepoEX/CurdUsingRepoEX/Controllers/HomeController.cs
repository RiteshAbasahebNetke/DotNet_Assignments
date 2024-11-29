using CurdUsingRepoEX.Models;
using CurdUsingRepoEX.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CurdUsingRepoEX.Controllers
{
    public class HomeController : Controller
    {
        ICategoryRepo crepo;
        IProductRepo prepo;
        public HomeController(ICategoryRepo crepo, IProductRepo prepo)
        {
            this.crepo = crepo;
            this.prepo = prepo;
        }

        public IActionResult Index()
        {
            return View(this.prepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(this.crepo.GetCategories(), "CategoryID", "CategoryName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product rec)
        {
            ViewBag.CategoryID=new SelectList(this.crepo.GetCategories(),"CategoryID","CategoryName");
            if(ModelState.IsValid)
            {
                this.prepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.prepo.GetById(id);
            ViewBag.CategoryID = new SelectList(this.crepo.GetCategories(), "CategoryID", "CategoryName");
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(Product rec)
        {
            ViewBag.CategoryID = new SelectList(this.crepo.GetCategories(), "CategoryID", "CategoryName");
            if (ModelState.IsValid)
            {
                this.prepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            ViewBag.CategoryID = new SelectList(this.crepo.GetCategories(), "CategoryID", "CategoryName");
            if (ModelState.IsValid)
            {
                this.prepo.Delete(id);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
