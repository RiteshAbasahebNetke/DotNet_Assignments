using CodeFirst_CURD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirst_CURD.Controllers
{
    public class TestController : Controller
    {
        CompanyContext cc = new CompanyContext();
        // GET: Test
        public ActionResult Index()
        {
            return View(this.cc.Products.ToList());
        }

        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            var rec = this.cc.Products.Find(id);
            ViewBag.CategoryId = new SelectList(this.cc.Categories.ToList(), "CategoryId", "CategoryName",rec.CategoryId);
            return View(rec);
        }
        [HttpPost]
        public ActionResult Edit(Product rec)
        {
            if (ModelState.IsValid)
            {
                this.cc.Entry(rec).State = System.Data.Entity.EntityState.Modified;
                this.cc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public ActionResult Delete(Int64 id)
        {
            var rec = this.cc.Products.Find(id);
            this.cc.Products.Remove(rec);
            this.cc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}