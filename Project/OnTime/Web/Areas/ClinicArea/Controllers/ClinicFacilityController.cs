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
            var id = Convert.ToInt64(HttpContext.Session.GetString("ClinicID"));
            return View(this.cfrepo.GetByCID(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            Int64 id = Convert.ToInt64(HttpContext.Session.GetString("ClinicID"));
            ViewBag.ClinicID = id;
            return View();
        }

        [HttpPost]
        public IActionResult Create(ClinicFacility rec)
        {
            
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
            Int64 cid = Convert.ToInt64(HttpContext.Session.GetString("ClinicID"));
            ViewBag.ClinicID = cid;
            var rec = this.cfrepo.GetByID(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(ClinicFacility rec)
        {
            
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
