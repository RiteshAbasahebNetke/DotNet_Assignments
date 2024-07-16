using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COREExamUsing5.Models
{
    [Table("EmpTbl")]
    public class Emp
    {
        [Key]
        public Int64 EmpID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public string Address { get; set; }
        public string EmailID { get; set; } 
        public string MobileNo { get; set; }
        public string JoinDate { get; set; }
        public virtual EmpSalary EmpSalary { get; set; }
        public virtual SalaryDeduction SalaryDeduction { get; set; }
        public virtual SalaryAddtion SalaryAddtion { get; set; }
    }
}
