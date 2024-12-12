using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEX
{
    class Bill
    {
        public int BillID;
        public string CustomerName;
        public string BillDate;

        public void addBill(int bi,string cn,string bd)
        {
            this.BillID = bi;
            this.CustomerName = cn;
            this.BillDate = bd;
        }
        public void DispBill()
        {
            Console.WriteLine("BillID is:"+ this.BillID);
            Console.WriteLine("Customer Name:"+ this.CustomerName);
            Console.WriteLine("Bill Date:"+ this.BillDate);
        }
    }

    class WaterBill : Bill
    {
        public int WaterBillNo;
        public int NoofUnits;
        public int RateperUnit;

        
        public void addWaterBill(int wb,int nu,int bi,string cn,string bd,int rt)
        {
            addBill(bi,cn,bd);
            this.WaterBillNo = wb;
            this.NoofUnits = nu;    
            this.RateperUnit = rt;
        }

        public void DispWaterBill()
        {
            DispBill();
            Console.WriteLine("Water Bill No:" + this.WaterBillNo);
            Console.WriteLine("No of Units:" + this.NoofUnits);
            Console.WriteLine("Rate per Unit:" + this.RateperUnit);
            Console.WriteLine("Amount is:" + this.NoofUnits * this.RateperUnit);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WaterBill w = new WaterBill();
            w.addWaterBill(121, 100, 111, "Ramesh", "12-10-2023", 2);
            w.DispWaterBill();
        }
    }
}
