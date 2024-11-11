using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CurdcoreEX.Models
{
    [Table("EmpTbl")]
    public class Emp
    {
        [Key]
        public Int64 EmpID { get; set; }
        public string EmpName { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }

        [ForeignKey("Dept")]
        public Int64 DeptID { get; set; }
        public virtual Dept Dept { get; set; }
    }
}
