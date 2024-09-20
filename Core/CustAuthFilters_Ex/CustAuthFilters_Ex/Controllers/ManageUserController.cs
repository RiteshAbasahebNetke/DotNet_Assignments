using CustAuthFilters_Ex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace CustAuthFilters_Ex.Controllers
{
    public class ManageUserController : Controller
    {
        // GET: ManageUser
        CustomAuthorizeEntities ca = new CustomAuthorizeEntities();
        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(LoginVM rec)
        {
            if(ModelState.IsValid)
            { 
                var urec = this.ca.UserTbls.SingleOrDefault(p => p.EmailID == rec.EmailID && p.Password == rec.Password);
                if(urec != null)
                {
                    Session["ID"] = urec.ID;
                    return RedirectToAction("Index", "UserHome", new { area = "UserArea" });
                }
                ModelState.AddModelError(" ","Please enter the correct login credentials");
            }
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
                UserTbl urec = new UserTbl();
                urec.FirstName = rec.FirstName;
                urec.LastName = rec.LastName;
                urec.Address = rec.Address;
                urec.EmailID = rec.EmailID;
                urec.MobileNo = rec.MobileNo;
                urec.Password = rec.Password;
                this.ca.UserTbls.Add(urec);
                this.ca.SaveChanges();

                return RedirectToAction("Index", "ManageUser");
            }
            return View(rec);
        }
        [HttpGet]
        public ActionResult LogOut()
        {
            Session.Clear();
            Session.Abandon();

            return View();
        }
    }
}