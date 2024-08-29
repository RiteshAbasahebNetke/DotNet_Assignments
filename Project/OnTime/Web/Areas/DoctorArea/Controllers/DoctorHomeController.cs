using Entity.Repositories.Interfaces;
using Entity.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.DoctorArea.Controllers
{
    [Area("DoctorArea")]
    public class DoctorHomeController : Controller
    {
        IDoctorRepo drepo;
        public DoctorHomeController(IDoctorRepo drepo)
        {
            this.drepo = drepo;
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
                Int64 doctorid = Convert.ToInt64(HttpContext.Session.GetString("DoctorID"));
                var res = this.drepo.ChangePassword(rec, doctorid);
                ModelState.AddModelError("", res.Message);
            }
            return View(rec);
        }
    }
}
