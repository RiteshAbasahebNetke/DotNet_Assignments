using Curd_Repo_Ex.Models;
using Curd_Repo_Ex.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Curd_Repo_Ex.Controllers
{
    public class HomeController : Controller
    {
        IEmpRepo emprepo;
        IDeptRepo deptrepo;
        public HomeController(IEmpRepo emprepo, IDeptRepo deptrepo)
        {
            this.emprepo = emprepo;
            this.deptrepo = deptrepo;
        }
        public IActionResult Index()
        {
            return View(this.emprepo.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Department = new SelectList(this.deptrepo.GetAllDepts(), "DeptID", "DeptName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Emp rec)
        {
            this.emprepo.Add(rec);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            ViewBag.Department = new SelectList(this.deptrepo.GetAllDepts(), "DeptID", "DeptName");
            var rec = this.emprepo.GetByID(id);
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(Emp rec)
        {
            this.emprepo.Edit(rec);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.emprepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
