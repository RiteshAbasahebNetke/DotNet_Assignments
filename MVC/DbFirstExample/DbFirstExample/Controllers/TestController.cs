using DbFirstExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DbFirstExample.Controllers
{
    public class TestController : Controller
    {
        curdopexEntities ce = new curdopexEntities();
        // GET: Test
        public ActionResult Index()
        {
            return View(this.ce.ProductTbls.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.CateGoryID = new SelectList(this.ce.CategoryTbls.ToList(), "CategoryID", "CategoryName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(ProductTbl rec)
        {
            if (ModelState.IsValid)
            {
                this.ce.ProductTbls.Add(rec);
                this.ce.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            ViewBag.CateGoryID = new SelectList(this.ce.CategoryTbls.ToList(), "CategoryID", "CategoryName");
            var rec=this.ce.ProductTbls.Find(id);
            return View(rec);
        }
        [HttpPost]
        public ActionResult Edit(ProductTbl rec)
        {
            if (ModelState.IsValid)
            {
                this.ce.Entry(rec).State = System.Data.EntityState.Modified;
                this.ce.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public ActionResult Delete(Int64 id)
        {
            if (ModelState.IsValid)
            {
                var rec = this.ce.ProductTbls.Find(id);
                this.ce.ProductTbls.Remove(rec);
                this.ce.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}