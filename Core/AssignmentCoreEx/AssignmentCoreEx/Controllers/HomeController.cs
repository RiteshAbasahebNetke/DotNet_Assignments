using AssignmentCoreEx.Models;
using AssignmentCoreEx.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentCoreEx.Controllers
{
    public class HomeController : Controller
    {
        IProductCategoryRepo prepo;
        IColorRepo crepo;
        IMfgRepo mrepo;
        IProductRepo prrepo;
        public HomeController(IProductCategoryRepo prepo, IColorRepo crepo, IMfgRepo mrepo, IProductRepo prrepo)
        {
            this.prepo = prepo;
            this.crepo = crepo;
            this.mrepo = mrepo;
            this.prrepo = prrepo;
        }

        public IActionResult Index()
        {
            return View(this.prrepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.ProductCategoryID = new SelectList(this.prepo.GetAll(), "ProductCategoryID", "CategoryName");
            ViewBag.MfgID = new SelectList(this.mrepo.GetAll(), "MfgID", "MfgName");
            ViewBag.ColorID = new SelectList(this.crepo.GetAll(), "ColorID", "ColorName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product rec)
        {
            ViewBag.ProductCategoryID = new SelectList(this.prepo.GetAll(), "ProductCategoryID", "CategoryName");
            ViewBag.MfgID = new SelectList(this.mrepo.GetAll(), "MfgID", "MfgName");
            ViewBag.ColorID = new SelectList(this.crepo.GetAll(), "ColorID", "ColorName");
            if (ModelState.IsValid)
            {
                this.prrepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
