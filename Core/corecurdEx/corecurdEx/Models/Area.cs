using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace corecurdEx.Models
{
    [Table("AreaTbl")]
    public class Area
    {
        [Key]
        public Int64 AreaID { get; set; }
        public string AreaName { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
