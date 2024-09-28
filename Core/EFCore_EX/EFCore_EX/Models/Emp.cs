using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore_EX.Models
{
    [Table("EmpTbl")]
    public class Emp
    {
        [Key]
        public Int64 EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmailId { get; set; }
        public decimal Salary { get; set; }

        [ForeignKey("DeptID")]
        public Int64 DeptID { get; set; }
        public virtual Department Department { get; set; }
    }
}
