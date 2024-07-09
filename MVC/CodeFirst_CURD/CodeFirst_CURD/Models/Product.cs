using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace CodeFirst_CURD.Models
{
    [Table("ProductTbl")]
    public class Product
    {
        [Key]
        public Int64 ProductId { get; set; }
        public string ProductName { get; set; }
        public string MfgName { get; set; }
        public decimal Price { get; set; }
        public Int64 CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}