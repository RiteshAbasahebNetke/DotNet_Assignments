using Db_First_EX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Db_First_EX.Controllers
{
    public class TestController : Controller
    {
        AEDEntities ae=new AEDEntities();
        // GET: Test
        public ActionResult Index()
        {
            //var v = from m in ae.EmpTbls
            //        where m.EmpId>2
            //        select m;

            var v = from m in ae.EmpTbls
                    join m1 in ae.DeptTbls
                    on m.DeptId equals m1.DeptId
                    select new EmpVM
                    {
                        EmpId = m.EmpId,
                        EmpName = m.EmpName,
                        EmailId = m.EmailId,
                        DeptId = m1.DeptId
                      //  Salary=m.Salary
                    };

            return View(v.ToList());
        }
    }
}