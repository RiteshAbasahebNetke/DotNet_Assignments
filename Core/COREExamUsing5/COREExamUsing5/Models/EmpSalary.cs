using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COREExamUsing5.Models
{
    [Table("EmpSalTbl")]
    public class EmpSalary
    {
        [Key]
        public Int64 EmpSalaryID { get; set; }
        public decimal BasicSalary { get; set; }

        [ForeignKey("Emp")]
        public Int64 EmpID { get; set; }
        public virtual Emp Emp { get; set; }
    }
}
