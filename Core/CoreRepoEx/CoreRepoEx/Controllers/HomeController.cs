using CoreRepoEx.Models;
using CoreRepoEx.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreRepoEx.Controllers
{
    public class HomeController : Controller
    {
        ICustomerRepo crepo;
        IAreaRepo arepo;
        public HomeController(ICustomerRepo crepo, IAreaRepo arepo)
        {
            this.crepo = crepo;
            this.arepo = arepo;
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
            ViewBag.AreaID=new SelectList(this.arepo.GetAll(),"AreaID","AreaName");
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
            var rec = this.crepo.GetById(id);
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(Customer rec)
        {
            ViewBag.AreaID = new SelectList(this.arepo.GetAll(), "AreaID", "AreaName");
            if (ModelState.IsValid)
            {
                this.crepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.crepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
