using CoreCurdUsingDIEx.Models;
using CoreCurdUsingDIEx.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreCurdUsingDIEx.Controllers
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
            ViewBag.CategoryID=new SelectList(this.crepo.GetAll(), "CategoryID", "CategoryName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product rec)
        {
            ViewBag.CategoryID = new SelectList(this.crepo.GetAll(), "CategoryID", "CategoryName");
            if (ModelState.IsValid)
            {
                this.prepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            ViewBag.CategoryID = new SelectList(this.crepo.GetAll(), "CategoryID", "CategoryName");
            var rec = this.prepo.GetByID(id); 
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(Product rec)
        {
            ViewBag.CategoryID = new SelectList(this.crepo.GetAll(), "CategoryID", "CategoryName");
            if (ModelState.IsValid)
            {
                this.prepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.prepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
