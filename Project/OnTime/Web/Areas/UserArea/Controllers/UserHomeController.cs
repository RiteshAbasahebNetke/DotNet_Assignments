using Core;
using Entity.Repositories.Interfaces;
using Entity.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    public class UserHomeController : Controller
    {
        IUserRepo urepo;
        public UserHomeController(IUserRepo urepo)
        {
            this.urepo = urepo;
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
                Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
                var res = this.urepo.ChangePassword(rec, userid);
                ModelState.AddModelError("", res.Message);
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult EditProfile()
        {
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));

            var rec = this.urepo.GetByID(userid);
            return View(rec);
        }


        [HttpPost]
        public IActionResult EditProfile(EditProfileVM rec)
        {
            if (ModelState.IsValid)
            {
                Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
                var res = this.urepo.EditProfile(rec, userid);
                ModelState.AddModelError("", res.Message);
            }
            return View(rec);
        }
    }
}
