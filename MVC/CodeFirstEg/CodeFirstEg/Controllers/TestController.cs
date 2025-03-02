using CodeFirstEg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstEg.Controllers
{
    public class TestController : Controller
    {
        CompanyContext cc=new CompanyContext();
        // GET: Test
        public ActionResult Index()
        {
            return View(this.cc.Emps.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.DeptID=new SelectList(this.cc.Depts.ToList(),"DeptID","DeptName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Emp rec)
        {
            ViewBag.DeptID = new SelectList(this.cc.Depts.ToList(), "DeptID", "DeptName");
            if (ModelState.IsValid)
            {
                this.cc.Emps.Add(rec);  
                this.cc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            ViewBag.DeptID = new SelectList(this.cc.Depts.ToList(), "DeptID", "DeptName");
            var rec=this.cc.Emps.Find(id);
            return View(rec);
        }
        [HttpPost]
        public ActionResult Edit(Emp rec)
        {
            ViewBag.DeptID = new SelectList(this.cc.Depts.ToList(), "DeptID", "DeptName");
            if (ModelState.IsValid)
            {
                this.cc.Entry(rec).State=System.Data.Entity.EntityState.Modified;
                this.cc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Delete(Int64 id)
        {
            var rec = this.cc.Emps.Find(id);
            this.cc.Emps.Remove(rec);
            return RedirectToAction("Index");
        }
    }
}