using CurdUsing_6Version.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CurdUsing_6Version.Controllers
{
    public class HomeController : Controller
    {
        CompanyContext cc;
        public HomeController(CompanyContext cc)
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
            ViewBag.Department = new SelectList(this.cc.Depts.ToList(), "DeptID", "DeptName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Emp rec)
        {
            this.cc.Emps.Add(rec);
            this.cc.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.cc.Emps.Find(id);
            ViewBag.Department = new SelectList(this.cc.Depts.ToList(), "DeptID", "DeptName");
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(Emp rec)
        {
            this.cc.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.cc.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(Int64 id)
        {
            var rec = this.cc.Emps.Find(id);
            this.cc.Emps.Remove(rec);
            this.cc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
