using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillInheritanceExample
{
    class Bill
    {
        private int BillNo;
        private string BillDate;
        private string CustomerName;
        
        protected void AddBill(int bn, string bd, string cn)
        {
            this.BillNo = bn;
            this.BillDate = bd;
            this.CustomerName = cn;
        }

        protected void DispBill()
        {
            Console.WriteLine("Bill No:" + this.BillNo);
            Console.WriteLine("Bill Date:" + this.BillDate);
            Console.WriteLine("CustomerName:"+ this.CustomerName);
        }
    }

    class WaterBill:Bill
    {
        private int MeterNo;
        private int NoofUnits;
        private double RatePerUnit;

        public void AddWaterBill(int bn, string bd, string cn,
                          int mn,int nu, double rpu)
        {
            AddBill(bn, bd, cn);
            this.MeterNo = mn;
            this.NoofUnits = nu;
            this.RatePerUnit = rpu;
        }

        public void DispWaterBill()
        {
            DispBill();
            Console.WriteLine("Meter No:"+ this.MeterNo);
            Console.WriteLine("NoOfUnits:" + this.NoofUnits);
            Console.WriteLine("RatePerUnit:" + this.RatePerUnit);
            Console.WriteLine("Amount:" + this.RatePerUnit * this.NoofUnits);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WaterBill wb=new WaterBill();
            wb.AddWaterBill(1, "21/9/2024", "Sunil", 123, 300, 1.50);
            wb.DispWaterBill();
        }
    }
}
