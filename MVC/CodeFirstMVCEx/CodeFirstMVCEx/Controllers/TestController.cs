using CodeFirstMVCEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstMVCEx.Controllers
{
    public class TestController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            return View(this.c.Emps.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.DeptID=new SelectList(this.c.Depts.ToList(),"DeptID","DeptName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Emp rec)
        {
            if(ModelState.IsValid)
            {
                this.c.Emps.Add(rec);
                this.c.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DeptID = new SelectList(this.c.Depts.ToList(), "DeptID", "DeptName");
            return View();
        }

        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            ViewBag.DeptID = new SelectList(this.c.Depts.ToList(), "DeptID", "DeptName");
            var rec=this.c.Emps.Find(id);
            return View(rec);
        }
        [HttpPost]
        public ActionResult Edit(Emp rec)
        {
            if (ModelState.IsValid)
            {
                this.c.Entry(rec).State=System.Data.Entity.EntityState.Modified;
                this.c.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DeptID = new SelectList(this.c.Depts.ToList(), "DeptID", "DeptName");
            return View(rec);
        }

        [HttpGet]
        public ActionResult Delete(Int64 id)
        {
            var rec = this.c.Emps.Find(id);
            this.c.Emps.Remove(rec);
            this.c.SaveChanges();  
            return RedirectToAction("Index");
        }
    }
}