using Core;
using Entity.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Areas.ClinicArea.Controllers
{
    [Area("ClinicArea")]
    public class OPDSessionController : Controller
    {
        IOPDSessionRepo orepo;
        IClinicRepo crepo;
        public OPDSessionController(IOPDSessionRepo orepo, IClinicRepo crepo)
        {
            this.orepo = orepo;
            this.crepo = crepo;
        }

        public IActionResult Index()
        {
            return View(this.orepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.ClinicID = new SelectList(this.crepo.GetAll(), "ClinicID", "ClinicName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(OPDSession rec)
        {
            ViewBag.ClinicID = new SelectList(this.crepo.GetAll(), "ClinicID", "ClinicName");
            if (ModelState.IsValid)
            {
                this.orepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            ViewBag.ClinicID = new SelectList(this.crepo.GetAll(), "ClinicID", "ClinicName");
            var rec = this.orepo.GetByID(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(OPDSession rec)
        {
            ViewBag.ClinicID = new SelectList(this.crepo.GetAll(), "ClinicID", "ClinicName");
            if (ModelState.IsValid)
            {
                this.orepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.orepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
