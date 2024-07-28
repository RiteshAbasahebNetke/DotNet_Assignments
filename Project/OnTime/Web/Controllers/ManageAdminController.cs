using Entity;
using Entity.Repositories.Interfaces;
using Entity.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ManageAdminController : Controller
    {
        IAdminRepo ar;
        public ManageAdminController(IAdminRepo ar)
        {
            this.ar = ar;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginVM rec)
        {
            if(ModelState.IsValid)
            {
                var res = this.ar.Login(rec);
                if(res.IsLoggedIn)
                {
                    HttpContext.Session.SetString("AdminID",res.LoggedInID.ToString());
                    HttpContext.Session.SetString("FullName", res.LoggedInName);

                    return RedirectToAction("Index", "AdminHome", new {area= "AdminArea" });
                }
                ModelState.AddModelError("", "Invalid EmailID or Password");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View();
        }
    }
}
