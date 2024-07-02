using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModelEX.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string MobileNo { get; set; }

        public Customer()
        {
            this.CustomerId = 963;
            this.CustomerName = "Raj";
            this.Address = "Shivajinagar, Pune";
            this.Age = 50;
            this.MobileNo = "8532104793";
        }
    }
}