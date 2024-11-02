using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace codefirstcurdop.Models
{
    [Table("CategoryTbl")]
    public class Category
    {
        [Key]
        public Int64 CategoryID { get; set; }
        public string CategoryName { get; set; }
        public virtual List<Product> Product { get; set; }
    }
}