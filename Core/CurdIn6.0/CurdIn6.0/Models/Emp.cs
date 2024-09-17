using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CurdIn6._0.Models
{
    [Table("EmpTbl")]
    public class Emp
    {
        [Key]
        public Int64 EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmailID { get; set; }
        public decimal Salary { get; set; }

        [ForeignKey("Department")]
        public Int64 DeptID { get; set; }
        public virtual Dept Department { get; set; }
    }
}
