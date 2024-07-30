using Core;
using Entity.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Areas.ClinicArea.Controllers
{
    [Area("ClinicArea")]
    public class ClinicFacilityController : Controller
    {
        IClinicFacilityRepo cfrepo;
        IClinicRepo crepo;
        public ClinicFacilityController(IClinicFacilityRepo cfrepo, IClinicRepo crepo)
        {
            this.cfrepo = cfrepo;
            this.crepo = crepo;
        }

        public IActionResult Index()
        {
            return View(this.cfrepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.ClinicID = new SelectList(this.crepo.GetAll(), "ClinicID", "ClinicName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(ClinicFacility rec)
        {
            ViewBag.ClinicID = new SelectList(this.crepo.GetAll(), "ClinicID", "ClinicName");
            if (ModelState.IsValid)
            {
                this.cfrepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            ViewBag.ClinicID = new SelectList(this.crepo.GetAll(), "ClinicID", "ClinicName");
            var rec = this.cfrepo.GetByID(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(ClinicFacility rec)
        {
            ViewBag.ClinicID = new SelectList(this.crepo.GetAll(), "ClinicID", "ClinicName");
            if (ModelState.IsValid)
            {
                this.cfrepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.cfrepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
