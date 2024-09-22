using DB_FIRST_C.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace DB_FIRST_C.Controllers
{
    public class TestController : Controller
    {
        AEDEntities ae = new AEDEntities();
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.DName = new SelectList(this.ae.DeptTbls.ToList(), "DeptId", "DeptName");
            return View(this.ae.EmpTbls.ToList());
        }

        public ActionResult SearchByName(string EName)
        {
            ViewBag.DName = new SelectList(this.ae.DeptTbls.ToList(), "DeptId", "DeptName");
            if (EName == null)
            {
                return View("Index", this.ae.EmpTbls.ToList());
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
                return View(this.ae.EmpTbls.ToList());
            }
            else
            {
                var lst = this.ae.EmpTbls.Where(p => p.DeptId == DName);
                return View("Index", lst.ToList());
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
            ViewBag.DeptId = new SelectList(this.ae.DeptTbls.ToList(), "DeptId", "DeptName");
            return View();
        }
        [HttpPost]
        public ActionResult Edit(EmpTbl rec)
        {
            var oldrec = this.ae.EmpTbls.Find(rec.EmpId);
            oldrec.EmpName = rec.EmpName;
            oldrec.EmailId = rec.EmailId;
            oldrec.Salary = rec.Salary;
            oldrec.DeptId = rec.DeptId;
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