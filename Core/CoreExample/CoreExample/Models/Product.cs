using CurdCoreExample.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreExample.Models
{
    [Table("ProductTbl")]
    public class Product
    {
        public Int64 ProductID {  get; set; }
        public string ProductName { get; set; }
        public string MfgName {  get; set; }
        public double Price {  get; set; }
        [ForeignKey("Category")]
        public Int64 CategoryID {  get; set; }
        public virtual Category Category { get; set; }  
    }
}
