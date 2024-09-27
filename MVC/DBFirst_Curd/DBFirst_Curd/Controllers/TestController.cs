using DBFirst_Curd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBFirst_Curd.Controllers
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

            if(EName==" ")
            {
                return View("Index", this.ae.EmpTbls.ToList());
            }
            else
            {
                var v = from m in this.ae.EmpTbls
                        where m.EmpName.StartsWith(EName)
                        select m;
                return View("Index",v.ToList());
            }
        }

        public ActionResult SearchDept(Int64 DName)
        {
            ViewBag.DName = new SelectList(this.ae.DeptTbls.ToList(), "DeptId", "DeptName");
            if (DName == 0)
            {
                return View("Index", this.ae.EmpTbls.ToList());
            }
            else
            {
                var n = this.ae.EmpTbls.Where(p => p.DeptId == DName);
                return View("Index", n.ToList());
            }
        }


        [HttpGet]
        public ActionResult Create()
        {

            ViewBag.DeptId = new SelectList(this.ae.EmpTbls.ToList(), "DeptId", "DeptName");
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmpTbl rec)
        {
            this.ae.EmpTbls.Add(rec);
            this.ae.SaveChanges();
            return RedirectToAction ("Index");
        }

        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            var rec = this.ae.EmpTbls.SingleOrDefault(p => p.EmpId == id);
            ViewBag.DeptId = new SelectList(this.ae.EmpTbls.ToList(), "DeptId", "DeptName");
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit (EmpTbl rec)
        {
            var oldrec = this.ae.EmpTbls.Find(rec.EmpId);
            oldrec.EmpId = rec.EmpId;
            oldrec.EmpName = rec.EmpName;
            oldrec.EmailId = rec.EmailId;
            oldrec.Salary = rec.Salary;
            oldrec.DeptId = rec.DeptId;
            this.ae.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}