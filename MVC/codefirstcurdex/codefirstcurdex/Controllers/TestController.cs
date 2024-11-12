using codefirstcurdex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace codefirstcurdex.Controllers
{
    public class TestController : Controller
    {
        CompanyContext cc=new CompanyContext();
        // GET: Test
        public ActionResult Index()
        {
            return View(this.cc.Products.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(this.cc.Categories.ToList(),"CategoryID","CategoryName");
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
            return View();
        }

        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            var rec = this.cc.Products.Find(id);
            ViewBag.CategoryID = new SelectList(this.cc.Categories.ToList(), "CategoryID", "CategoryName");
            return View(rec);
        }
        [HttpPost]
        public ActionResult Edit(Product rec)
        {
            ViewBag.CategoryID = new SelectList(this.cc.Categories.ToList(), "CategoryID", "CategoryName");
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