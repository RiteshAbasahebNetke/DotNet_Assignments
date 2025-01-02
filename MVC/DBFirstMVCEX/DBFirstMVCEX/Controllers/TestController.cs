using DBFirstMVCEX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBFirstMVCEX.Controllers
{
    
    public class TestController : Controller
    {
        CurdMVC28Entities cc = new CurdMVC28Entities();
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.ProductID = new SelectList(this.cc.CategoryTbls.ToList(), "ProductID", "ProductName");
            return View(this.cc.ProductTbls.ToList());
        }

        [HttpPost]
        public ActionResult SearchByName(string EName)
        {
            ViewBag.ProductID = new SelectList(this.cc.CategoryTbls.ToList(), "ProductID", "ProductName");
            if (EName=="" ||  EName==null)
            {
                return View(this.cc.ProductTbls.ToList());
            }
            else
            {
                var v = from m in this.cc.ProductTbls
                        where m.ProductName.StartsWith(EName)
                        select m;
                return View("Index",v.ToList());
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.ProductID = new SelectList(this.cc.CategoryTbls.ToList(), "ProductID", "ProductName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(ProductTbl rec)
        {
            if (ModelState.IsValid)
            {
                this.cc.ProductTbls.Add(rec);
                this.cc.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProductID = new SelectList(this.cc.CategoryTbls.ToList(), "ProductID", "ProductName");
            return View();
        }

        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            ViewBag.ProductID = new SelectList(this.cc.CategoryTbls.ToList(), "ProductID", "ProductName");
            var rec=this.cc.ProductTbls.Find(id);
            return View(rec);
        }
        [HttpPost]
        public ActionResult Edit(ProductTbl rec)
        {
            if (ModelState.IsValid)
            {
                this.cc.Entry(rec).State = System.Data.EntityState.Modified;
                this.cc.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProductID = new SelectList(this.cc.CategoryTbls.ToList(), "ProductID", "ProductName");
            return View(rec);
        }

        public ActionResult Delete(Int64 id)
        {
            var rec = this.cc.ProductTbls.Find(id);
            this.cc.ProductTbls.Remove(rec);
            this.cc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}