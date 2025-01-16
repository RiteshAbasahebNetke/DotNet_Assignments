using DBFirstCustomerEX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBFirstCustomerEX.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        CurdOfCoreEntities cc=new CurdOfCoreEntities();
        public ActionResult Index()
        {
            return View(this.cc.CustomerTbls.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.AreaID = new SelectList(this.cc.AreaTbls.ToList(), "AreaID", "AreaName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(CustomerTbl rec)
        {
            if(ModelState.IsValid)
            {
                this.cc.CustomerTbls.Add(rec);
                this.cc.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AreaID = new SelectList(this.cc.AreaTbls.ToList(), "AreaID", "AreaName");
            return View();
        }

        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            ViewBag.AreaID = new SelectList(this.cc.AreaTbls.ToList(), "AreaID", "AreaName");
            var rec = this.cc.CustomerTbls.Find(id);
            return View(rec);
        }

        [HttpPost]
        public ActionResult Edit(CustomerTbl rec)
        {
            if (ModelState.IsValid)
            {
                this.cc.Entry(rec).State=System.Data.EntityState.Modified;
                this.cc.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AreaID = new SelectList(this.cc.AreaTbls.ToList(), "AreaID", "AreaName");
            return View(rec);
        }

        [HttpGet]
        public ActionResult Delete(Int64 id)
        {
            var rec = this.cc.CustomerTbls.Find(id);
            this.cc.CustomerTbls.Remove(rec);
            this.cc.SaveChanges();
            return RedirectToAction("Index");   
        }
    }
}