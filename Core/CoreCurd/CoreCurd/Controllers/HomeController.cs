using CoreCurd.Models;
using CoreCurd.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreCurd.Controllers
{
    public class HomeController : Controller
    {
        IBusRepo brepo;
        ICityRepo crepo;
        public HomeController(IBusRepo brepo, ICityRepo crepo)
        {
            this.brepo = brepo;
            this.crepo = crepo;
        }

        public IActionResult Index()
        {
            return View(this.brepo.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.City = new SelectList(this.crepo.GetCities(), "CityID", "CityName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Bus rec)
        {
            if(ModelState.IsValid)
            { 
            this.brepo.Add(rec);
            return RedirectToAction("Index");
            }
            ViewBag.City = new SelectList(this.crepo.GetCities(), "CityID", "CityName");
            return View(rec);
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            ViewBag.City = new SelectList(this.crepo.GetCities(), "CityID", "CityName");
            var rec = this.brepo.GetByID(id);
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(Bus rec)
        {
            if (ModelState.IsValid)
            {
                this.brepo.Edit(rec);
                return RedirectToAction("Index");
            }
            ViewBag.City = new SelectList(this.crepo.GetCities(), "CityID", "CityName");
            return View(rec);
        }
        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.brepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
