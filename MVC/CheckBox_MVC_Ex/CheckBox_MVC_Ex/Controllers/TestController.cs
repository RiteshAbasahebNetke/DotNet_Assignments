using CheckBox_MVC_Ex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CheckBox_MVC_Ex.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        CheckBox_MVCEntities cm=new CheckBox_MVCEntities();
        public ActionResult Index()
        {
            var v = from m in cm.ProductTbls
                    select new CountVM
                    {
                        ProductID=m.ProductID,
                        ProductName=m.ProductName,
                        ColorCount = m.ProductColorTbls.Count()
                    };
            return View(v.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ProductTbl p,Int64 [] ck)
        {
            this.cm.ProductTbls.Add(p);
            this.cm.SaveChanges();
            foreach(Int64 cid in ck)
            {
                ProductColorTbl temp=new ProductColorTbl();
                temp.ColorID = cid;
                temp.ProductID = p.ProductID;
                this.cm.ProductColorTbls.Add(temp);
            }
            this.cm.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetCheckBoxes()
        {
            var v = from m in cm.ColorTbls
                    select new CheckBoxVM
                    {
                        Value = m.ColorID,
                        Text = m.ColorName,
                        ISelected = false
                    };
            return View("_CheckBoxList", v.ToList());
        }
        public ActionResult GetCheckBoxes1(Int64 ProductID)
        {
            var v = from m in cm.ColorTbls
                    select new CheckBoxVM
                    {
                        Value = m.ColorID,
                        Text = m.ColorName,
                        ISelected = this.cm.ProductColorTbls.Any(p => p.ColorID == m.ColorID && p.ProductID==ProductID),
                    };
            return View("_CheckBoxList", v.ToList());
        }
        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            var rec = this.cm.ProductTbls.Find(id);
            return View(rec);
        }
        [HttpPost]
        public ActionResult Edit(ProductTbl p, Int64[] ck)
        {
            //delete the old color records
            var oldcolors = this.cm.ProductColorTbls.Where(m => m.ProductID == p.ProductID);

            foreach(var temp in oldcolors)
            {
                this.cm.ProductColorTbls.Remove(temp);
            }
            this.cm.SaveChanges();

            this.cm.Entry(p).State = System.Data.Entity.EntityState.Modified;
            this.cm.SaveChanges();

            foreach(Int64 cid in ck)
            {
                ProductColorTbl temp=new ProductColorTbl();
                temp.ColorID = cid;
                temp.ProductID = p.ProductID;
                this.cm.ProductColorTbls.Add(temp);
            }
            this.cm.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}