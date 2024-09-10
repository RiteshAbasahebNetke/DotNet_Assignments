using Code_First_ex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Code_First_ex.Controllers
{
    public class TestController : Controller
    {
        CompanyContext cc = new CompanyContext();
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.CategoryID = new SelectList(this.cc.Categories.ToList(), "CategoryID", "CategoryName");
            return View(cc.Products.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(this.cc.Categories.ToList(), "CategoryID", "CategoryName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product rec)
        {
            ViewBag.CategoryID = new SelectList(this.cc.Categories.ToList(), "CategoryID", "CategoryName");
            if (ModelState.IsValid)
            {
                this.cc.Products.Add(rec);
                this.cc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            var rec = this.cc.Products.Find(id);
            ViewBag.CategoryID = new SelectList(this.cc.Categories.ToList(), "CategoryID", "CategoryName",rec.CategoryID);
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
        public ActionResult Delete(Int64 id)
        {
            var rec= this.cc.Products.Find(id);
            this.cc.Products.Remove(rec);
            this.cc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}