using DBFIRST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBFIRST.Controllers
{
    public class TestController : Controller
    {
        AEDEntities ae=new AEDEntities();
        // GET: Test
        public ActionResult Index()
        {
            //var v = from m in this.ae.EmpTbls
            //        where m.Salary > 50000
            //        select m;
            //return View(v.ToList());

            //var v = from m in ae.EmpTbls
            //        join m1 in ae.DeptTbls
            //        on m.DeptId equals m1.DeptId
            //        select new EmpVM
            //        {
            //            EmpId = m.EmpId,
            //            EmpName = m.EmpName,
            //            EmailId = m.EmailId,
            //            DeptId = m1.DeptId,
            //            Salary = m.Salary
            //        };

            var v = from m in ae.EmpTbls
                    join m1 in ae.DeptTbls
                    on m.DeptId equals m1.DeptId
                    join m2 in ae.AreaTbls
                    on m1.AreaId equals m2.AreaId
                    select new EmpVM
                    {
                        EmpId = m.EmpId,
                        EmpName = m.EmpName,
                        EmailId = m.EmailId,
                        DeptId = m1.DeptId,
                        Salary = m.Salary,
                        AreaId = m2.AreaId
                    };
            return View(v.ToList());
        }


        public ActionResult GetSummary()
        {
            var v = from m in this.ae.EmpTbls
                    join m1 in this.ae.DeptTbls
                    on m.DeptId equals m1.DeptId
                    group m by m1.DeptName into g
                    select new EmpSummary
                    {
                        DeptName = g.Key,
                        TotalSal = g.Sum(p => p.Salary),
                        MinSal = g.Min(p => p.Salary),
                        MaxSal = g.Max(p => p.Salary),
                        AvgSal = g.Average(p => p.Salary),
                        CountOfEmps=g.Count()
                    };
                  
            return View(v.ToList());
        }

        public ActionResult GetJoin()
        {
            var v = from m in this.ae.EmpTbls
                    join m1 in this.ae.DeptTbls
                    on m.DeptId equals m1.DeptId
                    select new AEDVM
                    {
                        EmpId = m.EmpId,
                        EmpName = m.EmpName,
                        DeptId = m1.DeptId,
                        DeptName = m1.DeptName
                    };
            return View(v.ToList());
        }
    }
}