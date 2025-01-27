using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignmentCoreEx.Models
{
    [Table("ColorTbl")]
    public class Color
    {
        [Key]
        public Int64 ColorID {  get; set; }
        public string ColorName {  get; set; }
        public virtual List<Product> Products { get; set; } 
    }
}
