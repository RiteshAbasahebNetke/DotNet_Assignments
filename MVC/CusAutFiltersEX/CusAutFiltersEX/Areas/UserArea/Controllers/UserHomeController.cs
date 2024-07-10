using CusAutFiltersEX.CusAutFilter;
using CusAutFiltersEX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CusAutFiltersEX.Areas.UserArea.Controllers
{
    [UserCusAus]
    public class UserHomeController : Controller
    {
        // GET: UserArea/UserHome
        CustomAuthorizeEntities cae = new CustomAuthorizeEntities();
        public ActionResult Index()
        {
            return View(this.cae.ProductTbls.ToList());
        }
    }
}