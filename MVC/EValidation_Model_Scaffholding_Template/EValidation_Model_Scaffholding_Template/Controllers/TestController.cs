using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using EValidation_Model_Scaffholding_Template.Models;
namespace EValidation_Model_Scaffholding_Template.Controllers
{
    public class TestController : Controller
    {
        AEDEntities ae = new AEDEntities();
        // GET: Test
        public ActionResult Index()
        {
            return View(this.ae.EmpTbls.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmpTbl rec)
        {
            if (ModelState.IsValid)
            {
                this.ae.EmpTbls.Add(rec);
                this.ae.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public ActionResult Edit(Int64? id)
        {
            var rec = this.ae.EmpTbls.Find(id);
            return View(rec);
        }

        [HttpPost]
        public ActionResult Edit(EmpTbl rec)
        {
            if (ModelState.IsValid)
            {
                this.ae.Entry(rec).State = System.Data.Entity.EntityState.Modified;
                this.ae.SaveChanges();
                return RedirectToAction("Index");
            }
            return View (rec);
        }
        [HttpGet]
        public ActionResult Details(Int64 id)
        {
            var rec=this.ae.EmpTbls.Find(id);
            return View(rec);
        }

        [HttpGet]
        public ActionResult Delete(Int64 id)
        {
            var rec = this.ae.EmpTbls.Find(id);
            return View(rec);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteRec(Int64 id)
        {
            var rec = this.ae.EmpTbls.Find(id);
            this.ae.EmpTbls.Remove(rec);
            this.ae.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}