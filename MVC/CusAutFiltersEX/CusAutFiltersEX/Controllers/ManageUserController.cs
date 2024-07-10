using CusAutFiltersEX.CusAutFilter;
using CusAutFiltersEX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CusAutFiltersEX.Controllers
{
    
    public class ManageUserController : Controller
    {
        CustomAuthorizeEntities cae=new CustomAuthorizeEntities();
        // GET: ManageUser

        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(LoginVM rec)
        {
            // check wheather user is exist in database
            var urec = this.cae.UserTbls.SingleOrDefault(p => p.EmailID == rec.EmailID && p.Password == rec.Password);
            if (urec != null)
            {
                //user logged in
                Session["UserID"]= urec.ID;
                Session["UserName"] = urec.FirstName;
                return RedirectToAction("Index", "UserHome", new { area = "UserArea" });
            }
            ModelState.AddModelError("", "Invalid EmailID or Password");
            return View(rec);
        }
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(UserVM rec)
        {
            if (ModelState.IsValid)
            {
                UserTbl urec=new UserTbl();
                urec.FirstName = rec.FirstName;
                urec.LastName = rec.LastName;
                urec.Address = rec.Address;
                urec.EmailID = rec.EmailID;
                urec.MobileNo = rec.MobileNo;  
                urec.Password = rec.Password;
                this.cae.UserTbls.Add(urec);
                this.cae.SaveChanges();

                return RedirectToAction("SignIn");
            }
            return View(rec);
        }
        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();

            return View();
        }
    }
}