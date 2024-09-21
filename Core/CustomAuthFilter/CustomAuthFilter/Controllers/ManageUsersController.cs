using CustomAuthFilter.Models;
using CustomAuthFilter.Repositories.Interfaces;
using CustomAuthFilter.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CustomAuthFilter.Controllers
{
    public class ManageUsersController : Controller
    {
        IUserRepo urepo;
        public ManageUsersController(IUserRepo urepo)
        {
            this.urepo = urepo;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginVM rec)
        {
            if (ModelState.IsValid)
            {
                var res = urepo.Login(rec);
                if (res.IsLoggedIn)
                {
                    HttpContext.Session.SetString("UserName", res.LoggedInName);
                    HttpContext.Session.SetString("UserID", res.LoggedInID.ToString());
                    return RedirectToAction("Index","Product");
                }
                ModelState.AddModelError("", "Invalid Login Credentials");
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
                return RedirectToAction("Login");
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
