using CodeFirstEx12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstEx12.Controllers
{
    public class TestController : Controller
    {
        Context c=new Context();
        // GET: Test
        public ActionResult Index()
        {
            return View(this.c.Products.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(this.c.Categories.ToList(), "CategoryID", "CategoryName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product rec)
        {
            ViewBag.CategoryID = new SelectList(this.c.Categories.ToList(), "CategoryID", "CategoryName");
            if (ModelState.IsValid)
            {
                this.c.Products.Add(rec);
                this.c.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            ViewBag.CategoryID = new SelectList(this.c.Categories.ToList(), "CategoryID", "CategoryName");
            var rec = this.c.Products.Find(id);
            return View(rec);
        }
        [HttpPost]
        public ActionResult Edit(Product rec)
        {
            ViewBag.CategoryID = new SelectList(this.c.Categories.ToList(), "CategoryID", "CategoryName");
            if (ModelState.IsValid)
            {
                this.c.Entry(rec).State = System.Data.Entity.EntityState.Modified;
                this.c.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public ActionResult Delete(Int64 id)
        {
            var rec= this.c.Products.Find(id);
            this.c.Products.Remove(rec);
            this.c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}