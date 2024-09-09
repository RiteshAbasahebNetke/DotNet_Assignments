using Code_First_Curd.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace Code_First_Curd.Controllers
{
    public class TestController : Controller
    {
        CompanyContext c = new CompanyContext();
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.DeptID = new SelectList(this.c.Depts.ToList(), "DeptID", "DeptName");
            return View(this.c.Emps.ToList());
        }

        public ActionResult SearchByName(string EName="")
        {
            ViewBag.DeptID = new SelectList(this.c.Depts.ToList(), "DeptID", "DeptName");
          
            if (EName == "")
            {
                return View("Index", this.c.Emps.ToList());
            }
            else
            {
                var v = this.c.Emps.Where(p => p.EmpName.StartsWith(EName));
                return View("Index", v.ToList());
            }
        }
        public ActionResult SearchByDept(Int64 DeptID = 0)
        {
            ViewBag.DeptID = new SelectList(this.c.Depts.ToList(), "DeptID", "DeptName");
            if (DeptID == 0)
            {
                return View("Index", this.c.Emps.ToList());
            }
            else
            {
                var v = this.c.Emps.Where(p => p.DeptID == DeptID);
                    return View("Index", v.ToList());
            }
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.DeptID = new SelectList(this.c.Depts.ToList(), "DeptID", "DeptName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Emp rec)
        {                   
                this.c.Emps.Add(rec);
                this.c.SaveChanges();
                this.c.Emps.ToList();
                return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(Int64? Id)
        {
            var rec = this.c.Emps.Find(Id);
            ViewBag.DeptID = new SelectList(this.c.Depts.ToList(), "DeptID", "DeptName",rec.DeptID);
            return View(rec);
        }
        [HttpPost]
        public ActionResult Edit(Emp rec)
        {
            var oldrec = this.c.Emps.Find(rec.EmpID);
            oldrec.EmpName = rec.EmpName;
            oldrec.EmailID = rec.EmailID;
            oldrec.DeptID = rec.DeptID;
            oldrec.Salary = rec.Salary;
            this.c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(Int64 Id)
        {
            var rec = this.c.Emps.Find(Id);
            this.c.Emps.Remove(rec);
            this.c.SaveChanges();
            return RedirectToAction("Index");
        }
         
    }
}
