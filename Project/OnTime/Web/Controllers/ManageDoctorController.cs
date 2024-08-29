using Entity.Repositories.Interfaces;
using Entity.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Controllers
{
    public class ManageDoctorController : Controller
    {
        IDoctorRepo drepo;
        IAreaRepo arepo;
        public ManageDoctorController(IDoctorRepo drepo, IAreaRepo arepo)
        {
            this.drepo = drepo;
            this.arepo = arepo;
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signin(LoginVM rec)
        {
            if (ModelState.IsValid)
            {
                var res = this.drepo.Signin(rec);
                if (res.IsLoggedIn)
                {
                    HttpContext.Session.SetString("DoctorID", res.LoggedInID.ToString());
                    HttpContext.Session.SetString("FirstName", res.LoggedInName);

                    return RedirectToAction("Index", "DoctorHome", new { area = "DoctorArea" });
                }

                ModelState.AddModelError("", "Invalid Email Id or Password");
            }
            return View(rec);
        }

        //[HttpGet]
        //public IActionResult SignUp()
        //{
        //    ViewBag.AreaID = new SelectList(this.arepo.GetAll(), "AreaID", "AreaName");
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult SignUp(UserVM rec)
        //{
        //    ViewBag.AreaID = new SelectList(this.arepo.GetAll(), "AreaID", "AreaName");
        //    if (ModelState.IsValid)
        //    {
        //        var res = this.urepo.Signup(rec);
        //        if (res.IsSuccess)
        //        {
        //            return RedirectToAction("SignIn", "ManageDoctor");
        //        }

        //        ModelState.AddModelError("", res.Message);
        //    }

        //    return View(rec);
        //}

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View();
        }
    }
}
