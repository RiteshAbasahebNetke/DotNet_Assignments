using db_first_exx.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace db_first_exx.Controllers
{
    public class TestController : Controller
    {
        AEDEntities ae=new AEDEntities();
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.DeptId = new SelectList(this.ae.DeptTbls.ToList(), "DeptId", "DeptName");
            return View(this.ae.EmpTbls.ToList());
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
        public ActionResult Edit(Int64? id)
        {
            var rec = this.ae.EmpTbls.Find(id);
            ViewBag.DeptId = new SelectList(this.ae.DeptTbls.ToList(), "DeptId", "DeptName",rec.DeptId);
            return View();
        }
        [HttpPost]
        public ActionResult Edit(EmpTbl rec)
        {
            //var oldrec = this.ae.EmpTbls.Find(rec.EmpId);
            //oldrec.EmpName = rec.EmpName;
            //oldrec.EmailId = rec.EmailId;
            //oldrec.DeptId = rec.DeptId;
            //oldrec.Salary = rec.Salary;

            this.ae.Entry(rec).State = System.Data.Entity.EntityState.Modified;
            this.ae.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Delete(Int64 id)
        {
            var rec = this.ae.EmpTbls.Find(id);
            this.ae.EmpTbls.Remove(rec);
            this.ae.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}