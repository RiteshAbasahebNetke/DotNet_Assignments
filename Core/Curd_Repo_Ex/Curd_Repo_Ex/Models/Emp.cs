using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Curd_Repo_Ex.Models
{
    [Table("EmpTbl")]
    public class Emp
    {
        [Key]
        public Int64 EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmailID { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }

        [ForeignKey("Department")]
        public Int64 DeptID { get; set; }
        public virtual Dept Department { get; set; }
    }
}
