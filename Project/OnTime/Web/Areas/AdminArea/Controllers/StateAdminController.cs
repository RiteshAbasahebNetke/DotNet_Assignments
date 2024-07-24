using Core;
using Entity.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web.CustAuthFilters;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [AdminAuth]
    public class StateAdminController : Controller
    {
        ICountryRepo crepo;
        IStateRepo srepo;
        
        public StateAdminController(ICountryRepo crepo, IStateRepo srepo)
        {
            this.crepo = crepo;
            this.srepo = srepo;
        }

        public IActionResult Index()
        {
            return View(this.srepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(State rec)
        {
            ViewBag.CountryID = new SelectList(this.crepo.GetAll(), "CountryID", "CountryName");
            if (ModelState.IsValid)
            {
                this.srepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(State rec)
        {
            ViewBag.CountryID = new SelectList(this.crepo.GetAll(), "CountryID", "CountryName");
            if (ModelState.IsValid)
            {
                this.srepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.srepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
