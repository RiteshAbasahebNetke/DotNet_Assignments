using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CurdOpUsingCodeFirstEx.Models
{
    [Table("AreaTbl")]
    public class Area
    {
        [Key]
        public Int64 AreaID { get; set; }
        public string AreaName { get; set; }
        public virtual List<Customer> Customer { get; set; }    
    }
}