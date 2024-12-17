using DBFirstEx12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBFirstEx12.Controllers
{
    public class TestController : Controller
    {
        codefirst12Entities ce = new codefirst12Entities();
        // GET: Test
        public ActionResult Index()
        {
            return View(this.ce.ProdTbls.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(this.ce.ProdTbls.ToList(), "CategoryID", "CategoryName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(ProdTbl rec)
        {
            ViewBag.CategoryID = new SelectList(this.ce.ProdTbls.ToList(), "CategoryID", "CategoryName");
            if (ModelState.IsValid)
            {
                this.ce.ProdTbls.Add(rec);
                this.ce.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            ViewBag.CategoryID = new SelectList(this.ce.ProdTbls.ToList(), "CategoryID", "CategoryName");
            var rec = this.ce.ProdTbls.Find(id);
            return View(rec);
        }
        [HttpPost]
        public ActionResult Edit(ProdTbl rec)
        {
            ViewBag.CategoryID = new SelectList(this.ce.ProdTbls.ToList(), "CategoryID", "CategoryName");
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
            var rec = this.ce.ProdTbls.Find(id);
            this.ce.ProdTbls.Remove(rec);
            this.ce.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}