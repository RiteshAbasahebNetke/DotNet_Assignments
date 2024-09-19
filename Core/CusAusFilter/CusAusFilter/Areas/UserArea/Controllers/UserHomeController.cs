using CusAusFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CusAusFilter.CustomAusFilter;


namespace CusAusFilter.Areas.UserArea.Controllers
{
    [CAFilter]
    public class UserHomeController : Controller
    {
        CustomAuthorizeEntities cae=new CustomAuthorizeEntities();
        // GET: UserArea/UserHome
        public ActionResult Index()
        {
            return View(this.cae.ProductTbls.ToList());
        }
     
    }
}