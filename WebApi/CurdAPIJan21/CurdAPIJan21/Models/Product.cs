using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CurdAPIJan21.Models
{
    [Table("ProductTbl")]
    public class Product
    {
        [Key]
        public Int64 ProductID {  get; set; }
        public string ProductName { get; set; }
        public string MfgName {  get; set; }
        public decimal Price {  get; set; }
    }
}
