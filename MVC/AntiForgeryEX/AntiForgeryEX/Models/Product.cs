using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AntiForgeryEX.Models
{
    public class Product
    {
        public Int64 ProductID { get; set; }
        public string ProductName { get; set; }
        public string MfgName { get; set; }
        public decimal Price { get; set; }
    }
}