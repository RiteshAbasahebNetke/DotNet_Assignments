using Core;
using Entity.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web.CustAuthFilters;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [AdminAuth]
    public class CityAdminController : Controller
    {
        IStateRepo srepo;
        ICityRepo ctrepo;
        public CityAdminController(IStateRepo srepo, ICityRepo ctrepo)
        {
            this.srepo = srepo;
            this.ctrepo = ctrepo;
        }

        public IActionResult Index()
        {
            return View(this.ctrepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.StateID = new SelectList(this.srepo.GetAll(), "StateID", "StateName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(City rec)
        {
            ViewBag.StateID = new SelectList(this.srepo.GetAll(), "StateID", "StateName");
            if (ModelState.IsValid)
            {
                this.ctrepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            ViewBag.StateID = new SelectList(this.srepo.GetAll(), "StateID", "StateName");
            var rec = this.ctrepo.GetByID(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(City rec)
        {
            ViewBag.StateID = new SelectList(this.srepo.GetAll(), "StateID", "StateName");
            if (ModelState.IsValid)
            {
                this.ctrepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.ctrepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
