using CurdOpUsingCodeFirstEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CurdOpUsingCodeFirstEx.Controllers
{
    public class TestController : Controller
    {
        CompanyContext cc=new CompanyContext();
        // GET: Test
        public ActionResult Index()
        {
            return View(this.cc.Customers.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.AreaID = new SelectList(this.cc.Areas.ToList(), "AreaID", "AreaName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Customer rec)
        {
            ViewBag.AreaID = new SelectList(this.cc.Areas.ToList(), "AreaID", "AreaName");
            if (ModelState.IsValid)
            {
                this.cc.Customers.Add(rec);
                this.cc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            ViewBag.AreaID = new SelectList(this.cc.Areas.ToList(), "AreaID", "AreaName");
            var rec = this.cc.Customers.Find(id);
            return View(rec);
        }
        [HttpPost]
        public ActionResult Edit(Customer rec)
        {
            ViewBag.AreaID = new SelectList(this.cc.Areas.ToList(), "AreaID", "AreaName");
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
            var rec=this.cc.Customers.Find(id);
            this.cc.Customers.Remove(rec);
            this.cc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}