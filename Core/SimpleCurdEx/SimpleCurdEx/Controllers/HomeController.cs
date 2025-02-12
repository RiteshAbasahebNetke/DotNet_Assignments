using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SimpleCurdEx.Models;

namespace SimpleCurdEx.Controllers
{
    public class HomeController : Controller
    {
        CompanyContext cc;
        public  HomeController(CompanyContext cc)
        {
            this.cc = cc;
        }
        public IActionResult Index()
        {
            return View(this.cc.Emps.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.DeptID=new SelectList(this.cc.Depts.ToList(),"DeptID","DeptName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Emp rec)
        {
            if(ModelState.IsValid)
            {
                this.cc.Emps.Add(rec);
                this.cc.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DeptID = new SelectList(this.cc.Depts.ToList(), "DeptID", "DeptName");
            return View();
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec=this.cc.Emps.Find(id);
            ViewBag.DeptID = new SelectList(this.cc.Depts.ToList(), "DeptID", "DeptName");
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(Emp rec)
        {
            if (ModelState.IsValid)
            {
                this.cc.Entry(rec).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
                this.cc.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DeptID = new SelectList(this.cc.Depts.ToList(), "DeptID", "DeptName");
            return View();
        }
        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            var rec = this.cc.Emps.Find(id);
            this.cc.Emps.Remove(rec);
            this.cc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
