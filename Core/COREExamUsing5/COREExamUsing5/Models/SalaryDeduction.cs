using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COREExamUsing5.Models
{
    [Table("SalDedTbl")]
    public class SalaryDeduction
    {
        [Key]
        public Int64 SalaryDeductionID { get; set; }
        public string DeductionName { get; set; }
        public decimal DeductionAmount { get; set; }

        [ForeignKey("Emps")]
        public Int64 EmpID { get; set; }
        public virtual Emp Emp { get; set; }
    }
}
