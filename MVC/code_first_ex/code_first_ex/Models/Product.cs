using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Code_First_ex.Models
{
    [Table("ProductTbl")]
    public class Product
    {
        [Key]
        public Int64 ProductID { get; set; }
        [Required(ErrorMessage ="ProductId is mandatory")]
        public string ProductName { get; set; }
        [Required(ErrorMessage ="Please enter the product name")]
        public  string MfgName { get; set; }
        [Required(ErrorMessage ="Please enter the mfg name")]
        public decimal Price { get; set; }
        [ForeignKey("Category")]
        [Required(ErrorMessage ="CategoryID is mandatory")]
        public Int64 CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}