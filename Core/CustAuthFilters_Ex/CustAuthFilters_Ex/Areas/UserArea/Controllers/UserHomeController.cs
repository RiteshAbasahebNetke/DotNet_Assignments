using CustAuthFilters_Ex.CustAutFilter;
using CustAuthFilters_Ex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustAuthFilters_Ex.Areas.UserArea.Controllers
{
    [UserAuthFilter]
    public class UserHomeController : Controller
    {
        CustomAuthorizeEntities ca = new CustomAuthorizeEntities();
        // GET: UserArea/UserHome
        public ActionResult Index()
        {
            return View(this.ca.ProductTbls.ToList());
        }
    }
}