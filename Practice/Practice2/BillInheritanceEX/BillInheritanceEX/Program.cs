using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillInheritanceEX
{
    class bill
    {
        private int BillNo;
        private string BillDate;
        private string CustomerName;

        public void Addbill(int bn,string bd,string cn)
        {
            this.BillNo = bn;
            this.BillDate = bd;
            this.CustomerName = cn;
        }
        public void Dispbill()
        {
            Console.WriteLine("BillNo:"+ this.BillNo);
            Console.WriteLine("Bill Date:" + this.BillDate);
            Console.WriteLine("Customer Name:"+ this.CustomerName);
        }
    }

    class WaterBill:bill
    {
        private int MeterNo;
        private int NoOfUnits;
        private double RateperUnit;

        public void AddWaterBill(int mn,int nu,double ru,int bn,string bd,string cn)
        {
            Addbill(bn, bd, cn);
            this.MeterNo = mn;
            this.NoOfUnits = nu;
            this.RateperUnit = ru;
        }
        public void DispWaterBill()
        {
            Dispbill();
            Console.WriteLine("Meter No:"+ this.MeterNo);
            Console.WriteLine("NoOfUnits:"+ this.NoOfUnits);
            Console.WriteLine("Rate per Unit:"+ this.RateperUnit);
            Console.WriteLine("Amount is:"+ this.NoOfUnits*this.RateperUnit);
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WaterBill wb = new WaterBill();
            wb.AddWaterBill(123, 100, 2, 111, "27-12-2023", "Sujit Patil");
            wb.DispWaterBill();
        }
    }
}
