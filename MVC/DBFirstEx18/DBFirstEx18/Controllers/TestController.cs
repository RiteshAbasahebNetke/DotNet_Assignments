using DBFirstEx18.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBFirstEx18.Controllers
{
    public class TestController : Controller
    {
        ProCatEntities pc = new ProCatEntities();
        // GET: Test
        public ActionResult Index()
        {
            return View(this.pc.ProductTbls.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(this.pc.CategoryTbls.ToList(), "CategoryId", "CategoryName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(ProductTbl rec)
        {
            ViewBag.CategoryId = new SelectList(this.pc.CategoryTbls.ToList(), "CategoryId", "CategoryName");
            if(ModelState.IsValid)
            {
                this.pc.ProductTbls.Add(rec);
                this.pc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            var rec = this.pc.ProductTbls.Find(id);
            ViewBag.CategoryId = new SelectList(this.pc.CategoryTbls.ToList(), "CategoryId", "CategoryName");
            return View(rec);
        }
        [HttpPost]
        public ActionResult Edit(ProductTbl rec)
        {
            ViewBag.CategoryId = new SelectList(this.pc.CategoryTbls.ToList(), "CategoryId", "CategoryName");
            if(ModelState.IsValid)
            {
                this.pc.Entry(rec).State = System.Data.EntityState.Modified;
                this.pc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public ActionResult Delete(Int64 id)
        {
            var rec = this.pc.ProductTbls.Find(id);
            this.pc.ProductTbls.Remove(rec);
            this.pc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}