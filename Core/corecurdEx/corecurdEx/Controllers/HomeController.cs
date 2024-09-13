using corecurdEx.Models;
using corecurdEx.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace corecurdEx.Controllers
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
        [HttpPost]
        public IActionResult SearchByArea(Int64 AID)
        {
            ViewBag.AreaID = new SelectList(this.arepo.GetAreas(), "AreaID", "AreaName");
            if (AID == 0)
            {
                return View("Index", this.crepo.GetAll());
            }
            else
            {
                return View("Index",this.crepo.GetByAreaID(AID));
            }
        }

        public IActionResult Index()
        {
            return View(this.crepo.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.AreaID= new SelectList(this.arepo.GetAreas(),"AreaID","AreaName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer rec)
        {
            if(ModelState.IsValid)
            { 
            this.crepo.Add(rec);
            return RedirectToAction("Index");
            }
            ViewBag.AreaID = new SelectList(this.arepo.GetAreas(), "AreaID", "AreaName");
            return View(rec);
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.crepo.GetById(id);
            ViewBag.AreaID = new SelectList(this.arepo.GetAreas(), "AreaID", "AreaName");
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(Customer rec)
        {
            if (ModelState.IsValid)
            {
                this.crepo.Edit(rec);
                return RedirectToAction("Index");
            }
            ViewBag.AreaID = new SelectList(this.arepo.GetAreas(), "AreaID", "AreaName");
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
