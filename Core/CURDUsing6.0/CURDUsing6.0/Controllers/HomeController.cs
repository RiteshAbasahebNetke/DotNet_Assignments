using CURDUsing6._0.Models;
using CURDUsing6._0.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CURDUsing6._0.Controllers
{
    public class HomeController : Controller
    {

        IDeptRepo drepo;
        IEmpRepo erepo;
        public HomeController(IDeptRepo drepo, IEmpRepo erepo)
        {
            this.drepo = drepo;
            this.erepo = erepo;
        }
        public IActionResult Index()
        {
            ViewBag.DeptID = new SelectList(this.drepo.GetAllDepts(), "DeptID", "DeptName");
            return View(this.erepo.GetAll());
        }

        [HttpPost]
        public IActionResult SearchByDep(Int64 DID)
        {
            ViewBag.DeptID = new SelectList(this.drepo.GetAllDepts(), "DeptID", "DeptName");
            if (DID == 0)
            {
                return View("Index",this.erepo.GetAll());
            }
            else
            {
              return View("Index",this.erepo.GetDepartment(DID));
            }
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Department = new SelectList(this.drepo.GetAllDepts(), "DeptID", "DeptName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Emp rec)
        {
            if(ModelState.IsValid)
            { 
            this.erepo.Add(rec);
            return RedirectToAction("Index");
            }
            ViewBag.Department = new SelectList(this.drepo.GetAllDepts(), "DeptID", "DeptName");
            return View(rec);
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            ViewBag.Department = new SelectList(this.drepo.GetAllDepts(), "DeptID", "DeptName");
            var rec = this.erepo.GetByID(id);
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(Emp rec)
        {
            if (ModelState.IsValid)
            {
                this.erepo.Edit(rec);
                return RedirectToAction("Index");
            }
            ViewBag.Department = new SelectList(this.drepo.GetAllDepts(), "DeptID", "DeptName");
            return View(rec);
        }
        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.erepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
