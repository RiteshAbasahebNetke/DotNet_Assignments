using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo_Curd.Models;
using Repo_Curd.Repositories.Interfaces;
using System;

namespace Repo_Curd.Controllers
{
    public class HomeController : Controller
    {
        IEmpRepo emprepo;
        IDeptRepo deptrepo;
        public HomeController(IEmpRepo emprepo,IDeptRepo deptrepo)
        {
            this.emprepo = emprepo;
            this.deptrepo = deptrepo;
        }
        public IActionResult Index()
        {
            ViewBag.Departments = new SelectList(this.deptrepo.GetAllDept(), "DeptID", "DeptName");
            return View(this.emprepo.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Departments = new SelectList(this.deptrepo.GetAllDept(),"DeptID","DeptName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Emp rec)
        {
            ViewBag.Departments = new SelectList(this.deptrepo.GetAllDept(), "DeptID", "DeptName");
            if (ModelState.IsValid)
            { 
            this.emprepo.Add(rec);
            return RedirectToAction("Index");
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.emprepo.GetByID(id);
            ViewBag.Departments = new SelectList(this.deptrepo.GetAllDept(), "DeptID", "DeptName");
           
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(Emp rec)
        {
            if (ModelState.IsValid)
            {
                this.emprepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        public IActionResult Delete(Int64 id)
        {
            this.emprepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
