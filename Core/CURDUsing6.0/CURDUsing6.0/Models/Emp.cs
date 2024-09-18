using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CURDUsing6._0.Models
{
    [Table("EmpTbl")]
    public class Emp
    {
        [Key]
        public Int64 EmpID { get; set; }
        [Required(ErrorMessage ="EmpName is mandatory")]
        public string EmpName { get; set; }
        [Required(ErrorMessage = "EmailId is mandatory")]
        [EmailAddress(ErrorMessage = "EmpName is mandatory")]
        public string EmailID { get; set; }
        [Required(ErrorMessage = "Address is mandatory")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Salary is mandatory")]
        [Range(14000,100000)]
        public decimal Salary { get; set; }

        [ForeignKey("Department")]
        public Int64 DeptID { get; set; }
        public virtual Dept Department { get; set; }
    }
}
