using System.ComponentModel.DataAnnotations.Schema;

namespace curdEX.Models
{
    [Table("DepTbl")]
    public class Dept
    {
        public Int64 DeptID { get; set; }
        public string DeptName { get; set; }
    }
}
