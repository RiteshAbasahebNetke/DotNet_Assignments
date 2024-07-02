using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModelEX.Models;

namespace ViewModelEX.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            ProCusEmpVM pce = new ProCusEmpVM();

            Product p = new Product();
            pce.ProductId = p.ProductId;
            pce.ProductName = p.ProductName;
            pce.Price = p.Price;

            Customer c = new Customer();
            pce.CustomerName = c.CustomerName;
            pce.Age = c.Age;
            pce.MobileNo = c.MobileNo;

            Emp e = new Emp();
            pce.EmpId = e.EmpId;
            pce.DeptName = e.DeptName;
            pce.Salary = e.Salary;

            return View(pce);
        }
    }
}