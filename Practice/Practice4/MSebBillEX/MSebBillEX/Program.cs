using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSebBillEX
{
    class Bill
    {
        public int BillID;
        public string CustomerName;
        public string BillDate;

        public void AddBill(int bi,string bd,string Cn)
        {
            this.BillID = bi;
            this.BillDate = bd;
            this.CustomerName = Cn;
        }
        public void DispBill()
        {
            Console.WriteLine("BillID:" + this.BillID);
            Console.WriteLine("Bill Date:" + this.BillDate);
            Console.WriteLine("Customer Name:"+ this.CustomerName);
        }
    }
    class MsebBill : Bill
    {
        public int MeterNo;
        public double NoofUnits;
        public double RateperUnit;

        public void AddMsebBill(int mn,double nu,double ru,int bi,string cn,string bd)
        {
            AddBill(bi, cn, bd);
            this.MeterNo = mn;
            this.NoofUnits = nu;
            this.RateperUnit = ru;
        }
        public void DispMsebBill()
        {
            DispBill();
            Console.WriteLine("Meter No:" + this.MeterNo);
            Console.WriteLine("No of Units:"+ this.NoofUnits);
            Console.WriteLine("Rate per Unit:" + this.RateperUnit);
            Console.WriteLine("Amount is:" + this.RateperUnit * this.NoofUnits);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MsebBill mb=new MsebBill();
            mb.AddMsebBill(123, 1000, 2, 121, "Rajesh", "20/11/24");
            mb.DispMsebBill();
        }
    }
}
