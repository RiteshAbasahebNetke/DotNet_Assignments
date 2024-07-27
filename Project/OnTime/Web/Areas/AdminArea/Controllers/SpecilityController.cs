using Core;
using Entity.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Web.CustAuthFilters;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [AdminAuth]
    public class SpecilityController : Controller
    {
        ISpecilityRepo srepo;
        public SpecilityController(ISpecilityRepo srepo)
        {
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
        public IActionResult Create(Specility rec)
        {

            if (ModelState.IsValid)
            {
                this.srepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.srepo.GetByID(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(Specility rec)
        {
            if (ModelState.IsValid)
            {
                this.srepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }
    }
}
