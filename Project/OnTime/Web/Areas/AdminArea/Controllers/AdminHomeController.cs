using Core;
using Entity.Repositories.Interfaces;
using Entity.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Web.CustAuthFilters;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [AdminAuth]
    public class AdminHomeController : Controller
    {
        IAdminRepo ar;
        public AdminHomeController(IAdminRepo ar)
        {
            this.ar = ar;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordVM rec)
        {
            if (ModelState.IsValid)
            {
                Int64 adminid = Convert.ToInt64(HttpContext.Session.GetString("AdminID"));
                var res = this.ar.ChangePassword(rec,adminid);
                ModelState.AddModelError("", res.Message);
            }
            return View(rec);
        }
    }
}
