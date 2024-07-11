using Microsoft.AspNetCore.Mvc;
using MVC_EX.Models;
using System;

namespace MVC_EX.Controllers
{
    public class AbcController:Controller
    {
        public string SayBye()
        {
            return "SayBye Called from Abc Controller...!";
        }
        public ActionResult GetProduct()
        {
            var lst = Product.GetProducts();
            return View(lst);
        }
    }
}
