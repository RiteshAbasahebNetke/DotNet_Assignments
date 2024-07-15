using EF_Core_Curd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;

namespace EF_Core_Curd.Controllers
{
    public class HomeController : Controller
    {
        CompanyContext cc;

        public HomeController(CompanyContext cc)
        {
            this.cc = cc;
        }
        public IActionResult SearchByCategory(Int64 CatId)
        {
            ViewBag.ProductCategories = new SelectList(this.cc.ProductCategories.ToList(), "ProductCategoryID", "ProductCategoryName");
            if (CatId == 0)
            {
                return View("Index", this.cc.Products.ToList());
            }
            else
            {
                var v = from m in this.cc.Products
                        where m.ProductCategoryID == CatId
                        select m;
                return View("Index", v.ToList());
            }
        }
        public IActionResult Index()
        {
            ViewBag.ProductCategories = new SelectList(this.cc.ProductCategories.ToList(), "ProductCategoryID", "ProductCategoryName");
            return View(this.cc.Products.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.ProductCategoryID = new SelectList(this.cc.ProductCategories.ToList(), "ProductCategoryID", "ProductCategoryName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product rec)
        {
            if(ModelState.IsValid)
            {
                this.cc.Products.Add(rec);
                this.cc.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProductCategoryID = new SelectList(this.cc.ProductCategories.ToList(), "ProductCategoryID", "ProductCategoryName");
            return View(rec);
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec=this.cc.Products.Find(id);
            ViewBag.ProductCategoryID = new SelectList(this.cc.ProductCategories.ToList(), "ProductCategoryID", "ProductCategoryName");
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(Product rec)
        {
            this.cc.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.cc.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            var rec = this.cc.Products.Find(id);
            this.cc.Products.Remove(rec);
            this.cc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
