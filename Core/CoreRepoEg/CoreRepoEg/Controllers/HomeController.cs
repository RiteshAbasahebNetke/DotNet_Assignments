using CoreRepoEg.Models;
using CoreRepoEg.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreRepoEg.Controllers
{
    public class HomeController : Controller
    {
        IAreaRepo arepo;
        ICustomerRepo crepo;
        public HomeController(IAreaRepo arepo, ICustomerRepo crepo)
        {
            this.arepo = arepo;
            this.crepo = crepo;
        }

        public IActionResult Index()
        {
            return View(this.crepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.AreaID = new SelectList(this.arepo.GetAll(), "AreaID", "AreaName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer rec)
        {
            ViewBag.AreaID = new SelectList(this.arepo.GetAll(), "AreaID", "AreaName");
            if(ModelState.IsValid)
            {
                this.crepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            ViewBag.AreaID = new SelectList(this.arepo.GetAll(), "AreaID", "AreaName");
            var rec=this.crepo.GetByID(id);
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(Customer rec)
        {
            ViewBag.AreaID = new SelectList(this.arepo.GetAll(), "AreaID", "AreaName");
            if (ModelState.IsValid)
            {
                this.crepo.Update(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            if (ModelState.IsValid)
            {
                this.crepo.Delete(id);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
