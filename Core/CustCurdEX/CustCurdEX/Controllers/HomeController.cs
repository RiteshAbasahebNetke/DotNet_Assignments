using CustCurdEX.Models;
using CustCurdEX.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CustCurdEX.Controllers
{
    public class HomeController : Controller
    {
        IAreaRepo arepo;
        ICustomerRepo crepo;
        public HomeController(IAreaRepo arepo, ICustomerRepo crepo)
        {
            this.arepo = arepo;
            this.crepo = crepo;
        }

        public IActionResult Index()
        {
            ViewBag.AreaID = new SelectList(this.arepo.GetAll(), "AreaID", "AreaName");
            return View(this.crepo.GetAll());
        }
        public IActionResult SearchByArea(Int64 AID)
        {
            ViewBag.AreaID = new SelectList(this.arepo.GetAll(), "AreaID", "AreaName");
            if (AID==0)
            {
                return View("Index",this.crepo.GetAll());
            }
            else
            {
                var res=this.crepo.GetCustomersByAID(AID);
                return View("Index",res.ToList());
            }
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.AreaID = new SelectList(this.arepo.GetAll(), "AreaID", "AreaName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer rec)
        {
            ViewBag.AreaID = new SelectList(this.arepo.GetAll(), "AreaID", "AreaName");
            if (ModelState.IsValid)
            {
                this.crepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            ViewBag.AreaID = new SelectList(this.arepo.GetAll(), "AreaID", "AreaName");
            var rec=this.crepo.GetByID(id);
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(Customer rec)
        {
            ViewBag.AreaID = new SelectList(this.arepo.GetAll(), "AreaID", "AreaName");
            if (ModelState.IsValid)
            {
                this.crepo.Edit(rec);
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
