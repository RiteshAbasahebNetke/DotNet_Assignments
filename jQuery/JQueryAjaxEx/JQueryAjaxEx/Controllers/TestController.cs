using JQueryAjaxEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JQueryAjaxEx.Controllers
{
    public class TestController : Controller
    {

        CommonEntities ce = new CommonEntities();
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetEmp()
        {
            return Json(this.ce.EmpTbls.ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}