using CURD_DBFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace CURD_DBFirst.Controllers
{
    public class TestController : Controller
    {
        AEDEntities ae=new AEDEntities();

        // GET: Test
        public ActionResult Index()
        {
            ViewBag.Dname = new SelectList(this.ae.DeptTbls.ToList(), "DeptId", "DeptName");
            return View(this.ae.EmpTbls.ToList());
        }
        public ActionResult SearchByName(string EName)
        {
            ViewBag.Dname = new SelectList(this.ae.DeptTbls.ToList(), "DeptId", "DeptName");
            if (EName == null || EName==" ")
            {
                return View("Index",this.ae.EmpTbls.ToList());
            }
            else
            {
                var v = from m in this.ae.EmpTbls
                        where m.EmpName.StartsWith(EName)
                        select m;

                return View("Index", v.ToList());
            }
        }
        public ActionResult SearchByDept(Int64 DName)
        {
            ViewBag.DName = new SelectList(this.ae.DeptTbls.ToList(), "DeptId", "DeptName");
            if (DName == 0)
            {
                return View("Index",this.ae.EmpTbls.ToList());
            }
            else
            {
                var w = this.ae.EmpTbls.Where(p => p.DeptId == DName);
                return View("Index", w.ToList());
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.DeptId = new SelectList(this.ae.DeptTbls.ToList(), "DeptId", "DeptName");
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmpTbl rec)
        {
            this.ae.EmpTbls.Add(rec);
            this.ae.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            var rec = this.ae.EmpTbls.Find(id);
            ViewBag.DeptID = new SelectList(this.ae.DeptTbls.ToList(), "DeptID", "DeptName", rec.DeptId);
            return View(rec);
        }
        [HttpPost]
        public ActionResult Edit(EmpTbl rec)
        {
            this.ae.Entry(rec).State = System.Data.Entity.EntityState.Modified;
            this.ae.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(Int64 id)
        {
            var rec=this.ae.EmpTbls.Find(id);
            this.ae.EmpTbls.Remove(rec);
            this.ae.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}