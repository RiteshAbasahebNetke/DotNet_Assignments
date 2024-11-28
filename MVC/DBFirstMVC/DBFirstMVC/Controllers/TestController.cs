using DBFirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBFirstMVC.Controllers
{
    public class TestController : Controller
    {
        CurdMVC28Entities ce=new CurdMVC28Entities();
        // GET: Test
        public ActionResult Index()
        {
            return View(this.ce.ProductTbls.ToList());
        }

        //[HttpPost]
        public ActionResult SearchByName(string PName)
        {
            ViewBag.CategoryID = new SelectList(this.ce.CategoryTbls.ToList(), "CategoryID", "CategoryName");
            if(PName == "" && PName == null)
            {
                return View("Index", this.ce.ProductTbls.ToList());
            }
            else
            {
                var v = from m in this.ce.ProductTbls
                        where m.ProductName.StartsWith(PName)
                        select m;
                return View("Index", v.ToList());
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(this.ce.CategoryTbls.ToList(), "CategoryID", "CategoryName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(ProductTbl rec)
        {
            ViewBag.CategoryID = new SelectList(this.ce.CategoryTbls.ToList(), "CategoryID", "CategoryName");
            if(ModelState.IsValid)
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
            ViewBag.CategoryID = new SelectList(this.ce.CategoryTbls.ToList(), "CategoryID", "CategoryName");
            var rec = this.ce.ProductTbls.Find(id);
            return View(rec);
        }
        [HttpPost]
        public ActionResult Edit(ProductTbl rec)
        {
            ViewBag.CategoryID = new SelectList(this.ce.CategoryTbls.ToList(), "CategoryID", "CategoryName");
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
            var rec = this.ce.ProductTbls.Find(id);
            this.ce.ProductTbls.Remove(rec);
            this.ce.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}