using EFCore_EX.ENum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore_EX.Models
{
    [Table ("Product")]
    public class Product
    {
        [Key]
        public Int64 ProductID { get; set; }
        public string ProductName { get; set; }
        public string MfgName { get; set; }
        public decimal Price { get; set; }
        public ColorEnum ProductColor { get; set; } 

        [ForeignKey("ProductCategoryID")]
        public Int64 ProductCategoryID { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
    }
}
