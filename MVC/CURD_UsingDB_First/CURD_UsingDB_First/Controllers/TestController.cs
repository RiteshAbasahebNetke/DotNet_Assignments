using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using CURD_UsingDB_First.Models;

namespace CURD_UsingDB_First.Controllers
{
    public class TestController : Controller
    {
        CommonEntities ce = new CommonEntities();
        // GET: Test
        public ActionResult Index()
        {
              return View(this.ce.EmpTbls.ToList());
            //var v = from m in this.ce.EmpTbls
            //        where m.Salary > 40000
            //        select m;

            //var v = from m in ce.EmpTbls
            //        join m1 in ce.DeptTbls
            //        on m.DeptId equals m1.DeptId
            //        select new EmpVM
            //        {
            //            EmpId = m.EmpId,
            //            EmpName = m.EmpName,
            //            EmailId = m.EmailId,
            //            DeptId = m1.DeptId,
            //            Salary=m.Salary
            //        };

            //var v = from m in ce.EmpTbls
            //        join m1 in ce.DeptTbls
            //        on m.DeptId equals m1.DeptId
            //        join m2 in ce.AreaTbls
            //        on m1.DeptId equals m2.DeptId
            //        select new EmpVM
            //        {
            //            EmpId = m.EmpId,
            //            EmpName = m.EmpName,
            //            EmailId = m.EmailId,
            //            Salary = m.Salary,
            //            DeptId = m1.DeptId,
            //            DeptName = m1.DeptName,
            //            AreaName = m2.AreaName
            //        };
            //return View(v.ToList());
        }

        public ActionResult GetSummary()
        {
            var v = from m in ce.EmpTbls
                    join m1 in ce.DeptTbls
                    on m.DeptId equals m1.DeptId
                    group m by m1.DeptName into g
                    select new EmpSummary
                    {
                        DeptName = g.Key,
                        TotalSalary = g.Sum(p => p.Salary),
                        MaxSalary = g.Max(p => p.Salary),
                        MinSalary = g.Min(p => p.Salary),
                        AvgSalary = g.Average(p => p.Salary),
                        CountOfEmp = g.Count()
                    };
            return View(v.ToList());
        }

    }
}