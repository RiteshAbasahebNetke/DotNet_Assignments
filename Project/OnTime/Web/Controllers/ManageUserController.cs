using Entity.Repositories.Interfaces;
using Entity.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Controllers
{
    public class ManageUserController : Controller
    {
        IUserRepo urepo;
        ICountryRepo crepo;
        public ManageUserController(IUserRepo urepo,ICountryRepo crepo)
        {
            this.urepo = urepo;
            this.crepo = crepo;
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(LoginVM rec)
        {
            if (ModelState.IsValid)
            {
                var res = this.urepo.Signin(rec);
                if (res.IsLoggedIn)
                {
                    HttpContext.Session.SetString("UserID", res.LoggedInID.ToString());
                    HttpContext.Session.SetString("FirstName", res.LoggedInName);

                    return RedirectToAction("Index", "UserHome",new {area="UserArea"});
                }

                ModelState.AddModelError("", "Invalid Email Id or Password");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            ViewBag.CountryID = new SelectList(this.crepo.GetAll(), "CountryID", "CountryName");
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(UserVM rec)
        {
            ViewBag.CountryID = new SelectList(this.crepo.GetAll(), "CountryID", "CountryName");
            if (ModelState.IsValid)
            {
                var res = this.urepo.Signup(rec);
                if (res.IsSuccess)
                {
                    return RedirectToAction("SignIn","ManageUser");
                }

                ModelState.AddModelError("", res.Message);
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
