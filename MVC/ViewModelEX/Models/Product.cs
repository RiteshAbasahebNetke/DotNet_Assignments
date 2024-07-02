using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModelEX.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string MfgName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Product()
        {
            this.ProductId = 125;
            this.ProductName = "Mouse";
            this.MfgName = "Dell";
            this.Description = "Keep Away from Children";
            this.Price = 690;
        }
    }
}