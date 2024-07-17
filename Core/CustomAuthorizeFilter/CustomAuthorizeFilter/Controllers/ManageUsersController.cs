using CustomAuthorizeFilter.Models;
using CustomAuthorizeFilter.Repositories.Interface;
using CustomAuthorizeFilter.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CustomAuthorizeFilter.Controllers
{
    public class ManageUsersController : Controller
    {
        IUserRepo urepo;
        public ManageUsersController(IUserRepo urepo)
        {
            this.urepo = urepo;
        }
        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LogIn(LoginVM rec)
        {
            if (ModelState.IsValid)
            {
                var res=this.urepo.Login(rec);
                if (res.IsLoggedIn)
                {
                    HttpContext.Session.SetString("UserName", res.LoggedInName);
                    HttpContext.Session.SetString("UserID", res.LoggedInID.ToString());
                    return RedirectToAction("Index","Product");
                }
                ModelState.AddModelError("", "Invalid EmailID or Password");
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User rec)
        {
            if (ModelState.IsValid)
            {
                this.urepo.Register(rec);
                return RedirectToAction("LogIn");
            }
            return View(rec);
        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return View(); 
        }
    }
}
