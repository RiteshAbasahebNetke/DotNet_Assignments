using CurdOpUsingDBFirstEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.Mvc;

namespace CurdOpUsingDBFirstEx.Controllers
{
    public class TestController : Controller
    {
        CurdOp9Entities ce = new CurdOp9Entities();
        // GET: Test
        public ActionResult Index()
        {
            return View(this.ce.CustomerTbls.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.AreaID = new SelectList(this.ce.CustomerTbls.ToList(), "AreaID", "AreaName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(CustomerTbl rec)
        {
            ViewBag.AreaID = new SelectList(this.ce.CustomerTbls.ToList(), "AreaID", "AreaName");
            if(ModelState.IsValid)
            {
                this.ce.CustomerTbls.Add(rec);
                this.ce.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            ViewBag.AreaID = new SelectList(this.ce.CustomerTbls.ToList(), "AreaID", "AreaName");
            var rec=this.ce.CustomerTbls.Find(id);
            return View(rec);
        }
        [HttpPost]
        public ActionResult Edit(CustomerTbl rec)
        {
            ViewBag.AreaID = new SelectList(this.ce.CustomerTbls.ToList(), "AreaID", "AreaName");
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
            var rec = this.ce.CustomerTbls.Find(id);
            this.ce.CustomerTbls.Remove(rec);
            this.ce.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}