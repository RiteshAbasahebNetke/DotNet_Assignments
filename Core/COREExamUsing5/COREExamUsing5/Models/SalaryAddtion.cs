using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace COREExamUsing5.Models
{
    [Table("SalAddTbl")]
    public class SalaryAddtion
    {
        [Key]
        public Int64 SalaryAdditionID { get; set; }
        public string AdditionName { get; set; }
        public decimal AdditionAmount { get; set; }

        [ForeignKey("Emps")]
        public Int64 EmpID { get; set; }
        public virtual Emp Emp { get; set; }
    }
}
