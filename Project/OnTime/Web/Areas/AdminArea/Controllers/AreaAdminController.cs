using Core;
using Entity.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web.CustAuthFilters;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [AdminAuth]
    public class AreaAdminController : Controller
    {
        IAreaRepo arepo;
        ICityRepo ctrepo;
        public AreaAdminController(IAreaRepo arepo, ICityRepo ctrepo)
        {
            this.arepo = arepo;
            this.ctrepo = ctrepo;
        }

        public IActionResult Index()
        {
            return View(this.arepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CityID = new SelectList(this.ctrepo.GetAll(), "CityID", "CityName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Area rec)
        {
            ViewBag.CityID = new SelectList(this.ctrepo.GetAll(), "CityID", "CityName");
            if (ModelState.IsValid)
            {
                this.arepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            ViewBag.CityID = new SelectList(this.ctrepo.GetAll(), "CityID", "CityName");
            var rec = this.arepo.GetByID(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(Area rec)
        {
            ViewBag.CityID = new SelectList(this.ctrepo.GetAll(), "CityID", "CityName");
            if (ModelState.IsValid)
            {
                this.arepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.arepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
