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
            var id = Convert.ToInt64(HttpContext.Session.GetString("ClinicID"));
            return View(this.orepo.GetByOID(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            Int64 id = Convert.ToInt64(HttpContext.Session.GetString("ClinicID"));
            ViewBag.ClinicID = id;
            return View();
        }

        [HttpPost]
        public IActionResult Create(OPDSession rec)
        {
            
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
            Int64 oid = Convert.ToInt64(HttpContext.Session.GetString("ClinicID"));
            ViewBag.ClinicID = oid;
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
