using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RepoCURD.Models;
using RepoCURD.Repositories.Interfaces;
using System;

namespace RepoCURD.Controllers
{
    public class HomeController : Controller
    {
        IEmpRepo emprepo;
        IDeptRepo deptRepo;
        public HomeController(IEmpRepo emprepo, IDeptRepo deptrepo)
        {
            this.emprepo = emprepo;
            this.deptRepo = deptrepo;
        }

        public IActionResult Index()
        {
            ViewBag.DeptID = new SelectList(this.deptRepo.GetAllDept(), "DeptID", "DeptName");
            return View(this.emprepo.GetAll());
        }
        [HttpPost]
        public IActionResult SearchByDept(Int64 DeptID)
        {
            ViewBag.DeptID = new SelectList(this.deptRepo.GetAllDept(), "DeptID", "DeptName");
            if (DeptID == 0)
            {
                return View("Index", this.emprepo.GetAll());
            }
            else
            {
                return View("Index", this.emprepo.GetEmpByDeptID(DeptID));
            }
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Department = new SelectList(this.deptRepo.GetAllDept(), "DeptID", "DeptName");
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
            var rec = this.emprepo.GetByID(id);
            ViewBag.Department = new SelectList(this.deptRepo.GetAllDept(), "DeptID", "DeptName");
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
