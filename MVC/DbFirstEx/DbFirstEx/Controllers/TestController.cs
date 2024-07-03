using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DbFirstEx.Models;
namespace DbFirstEx.Controllers
{
    public class TestController : Controller
    {
        // GET: Test

        EMPEntities e = new EMPEntities();
        public ActionResult Index()
        {
            return View(this.e.Product_T.ToList());
        }
    }
}