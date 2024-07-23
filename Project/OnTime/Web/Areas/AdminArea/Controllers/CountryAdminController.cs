using Core;
using Entity.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Areas.AdminArea.Controllers
{
    public class CountryAdminController : Controller
    {
        ICountryRepo crepo;
        public CountryAdminController(ICountryRepo crepo)
        {
            this.crepo = crepo;
        }

        public IActionResult Index()
        {
            return View(this.crepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Country rec)
        {
            ViewBag.MainCategories = new SelectList(this.crepo.GetAll(), "CountryID", "CountryName");
            if (ModelState.IsValid)
            {
                this.crepo.Add(rec);
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
        public IActionResult Edit(Country rec)
        {
            ViewBag.MainCategories = new SelectList(this.crepo.GetAll(), "CountryID", "CountryName");
            if (ModelState.IsValid)
            {
                this.crepo.Add(rec);
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
