using curdEX.Models;
using curdEX.Repositiories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace curdEX.Controllers
{
    public class HomeController : Controller
    {
        IDeptRepo drepo;
        IEmpRepo erepo;
        public HomeController(IDeptRepo drepo,IEmpRepo erepo)
        {
            this.drepo = drepo;
            this.erepo = erepo;
        }

        public IActionResult Index()
        {
            return View("Index",this.erepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.DeptID = new SelectList(this.drepo.GetAllDept(), "DeptID", "DeptName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Emp rec)
        {
            ViewBag.DeptID = new SelectList(this.drepo.GetAllDept(), "DeptID", "DeptName");
            if(ModelState.IsValid)
            {
                this.erepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            ViewBag.DeptID = new SelectList(this.drepo.GetAllDept(), "DeptID", "DeptName");
            var rec = this.erepo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(Emp rec)
        {
            ViewBag.DeptID = new SelectList(this.drepo.GetAllDept(), "DeptID", "DeptName");
            if(ModelState.IsValid)
            {
                this.erepo.Edit(rec);
                return RedirectToAction("Index");
            }
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
