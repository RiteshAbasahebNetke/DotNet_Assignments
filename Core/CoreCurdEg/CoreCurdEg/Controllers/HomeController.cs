﻿using CoreCurdEg.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreCurdEg.Controllers
{
    public class HomeController : Controller
    {
        CompanyContext cc;
        public HomeController(CompanyContext cc)
        {
            this.cc = cc;
        }

        public IActionResult Index()
        {
            return View(this.cc.Customers.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.AreaID=new SelectList(this.cc.Areas.ToList(),"AreaID","AreaName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer rec)
        {
            ViewBag.AreaID = new SelectList(this.cc.Areas.ToList(), "AreaID", "AreaName");
            if (ModelState.IsValid)
            {
                this.cc.Customers.Add(rec);
                this.cc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            ViewBag.AreaID = new SelectList(this.cc.Areas.ToList(), "AreaID", "AreaName");
            var rec = this.cc.Customers.Find(id);
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(Customer rec)
        {
            ViewBag.AreaID = new SelectList(this.cc.Areas.ToList(), "AreaID", "AreaName");
            if (ModelState.IsValid)
            {
                this.cc.Entry(rec).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
                this.cc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            var rec = this.cc.Customers.Find(id);
            this.cc.Customers.Remove(rec);
            this.cc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
