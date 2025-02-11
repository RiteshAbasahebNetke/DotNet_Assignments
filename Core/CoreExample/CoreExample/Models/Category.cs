using CoreExample.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace CurdCoreExample.Models
{
    [Table("CategoryTbl")]
    public class Category
    {
        public Int64 CategoryID { get; set; }
        public string CategoryName { get; set; }    
        public virtual List<Product> Products { get; set; } 
    }
}
