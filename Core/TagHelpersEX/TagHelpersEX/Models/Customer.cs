using System;
using TagHelpersEX.ENum;

namespace TagHelpersEX.Models
{
    public class Customer
    {
        public Int64 CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public Int64 CityID { get; set; }
        public string EmailID { get; set; }
        public string MobileNo { get; set; }
        public CusCategoryENum CustomerCategory { get; set; }
    }
}
