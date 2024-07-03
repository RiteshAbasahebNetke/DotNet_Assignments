using DB_First_CURD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace DB_First_CURD.Controllers
{
    public class TestController : Controller
    {
        // GET: Test

        CommonEntities ce = new CommonEntities();
        public ActionResult Index()
        {
            ViewBag.DName = new SelectList(this.ce.DeptTbls.ToList(), "DeptId", "DeptName");
            return View(this.ce.EmpTbls.ToList());
        }
        public ActionResult SearchByName(string EName)
        {
            ViewBag.DName = new SelectList(this.ce.DeptTbls.ToList(), "DeptId", "DeptName");

            if (EName==" " || EName == null)
            {
                return View("Index", ce.EmpTbls.ToList());
            }
            else
            {
                var v = from m in this.ce.EmpTbls
                        where m.EmpName.StartsWith(EName)
                        select m;
                return View("Index", v.ToList());
            }
        }
        public ActionResult SearchByDept(Int64 DName)
        {
            ViewBag.DName = new SelectList(this.ce.DeptTbls.ToList(), "DeptId", "DeptName");
            if (DName == 0)
            {
                return View("Index", this.ce.EmpTbls.ToList());
            }
            else
            {
                var t = this.ce.EmpTbls.Where(p => p.DeptId == DName);
                return View("Index", t.ToList());
            }
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.DeptId = new SelectList(this.ce.DeptTbls.ToList(), "DeptId", "DeptName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmpTbl rec)
        {
            this.ce.EmpTbls.Add(rec);
            this.ce.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            // var rec = this.ce.EmpTbls.SingleOrDefault(p => p.EmpId == id);
            var rec = this.ce.EmpTbls.Find(id);
            ViewBag.DeptId = new SelectList(this.ce.EmpTbls.ToList(), "DeptId", "DeptName", rec.DeptId);
            return View(rec);
            
        }

        [HttpPost]
        public ActionResult Edit(EmpTbl rec)
        {
            //var oldrec = this.ce.EmpTbls.Find(rec.EmpId);
            //oldrec.EmpId = rec.EmpId;
            //oldrec.EmpName = rec.EmpName;
            //oldrec.EmailId = rec.EmailId;
            //oldrec.Salary = rec.Salary;
            //oldrec.DeptId = rec.DeptId;
            //this.ce.SaveChanges();

            this.ce.Entry(rec).State=System.Data.Entity.EntityState.Modified;
            this.ce.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Delete(Int64 id)
        {
            var rec = this.ce.EmpTbls.Find(id);
            this.ce.EmpTbls.Remove(rec);
            this.ce.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}