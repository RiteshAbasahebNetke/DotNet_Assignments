using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_BillEx
{
    class Bill
    {
        public int BillNo;
        public string BillDate;
        public string CustomerName;

        public void AddBill(int bn,string bd,string cn)
        {
            this.BillNo = bn;
            this.BillDate = bd;
            this.CustomerName = cn;
        }
        public void DispBill()
        {
            Console.WriteLine("Bill No:"+ this.BillNo);
            Console.WriteLine("Bill Date:" + this.BillDate);
            Console.WriteLine("Customer Name:" + this.CustomerName);
        }
    }
    class WaterBill:Bill
    {
        public int WaterMeterNo;
        public double Quantity;
        public double Price;
        
        public void AddWaterBill(int wm,double q,double p,int bn,string bd,string cn)
        {
            AddBill(bn, bd, cn);
            this.WaterMeterNo = wm;
            this.Quantity = q;
            this.Price = p;
        }
        public void DispWaterBill()
        {
            DispBill();
            Console.WriteLine("Water Meter No:"+ this.WaterMeterNo);
            Console.WriteLine("Quantity:"+ this.Quantity);
            Console.WriteLine("Price:"+ this.Price);
            Console.WriteLine("Water Bill Amount is:"+ this.Quantity*this.Price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WaterBill w=new WaterBill();
            w.AddWaterBill(1, 1000, 10, 121, "30-1-2025", "Rajesh");
            w.DispWaterBill();
        }
    }
}
