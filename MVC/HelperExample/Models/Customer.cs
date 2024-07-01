using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelperExample.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; } 
        public string City { get; set; }
        public string MobileNo { get; set; }

        public Customer()
        {
            this.CustomerId = 1;
            this.CustomerName = "Suresh";
            this.Address = "Akurdi";
            this.City = "Pune";
            this.MobileNo = "8563214796";
        }
    }
}