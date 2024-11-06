using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CurdOperationEx.Models
{
    [Table("ProductTbl")]
    public class Product
    {
        [Key]
        public Int64 ProductID { get; set; }
        [Required(ErrorMessage ="Please enter Product Name")]
        public string ProductName { get; set; }
        [Required(ErrorMessage ="Please enter Mfg Name")]
        public string MfgName { get; set; }
        [Required(ErrorMessage ="Please enter Price")]
        [Range(300,30000)]
        public double Price { get; set; }

        [ForeignKey("Category")]
        public Int64 CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
