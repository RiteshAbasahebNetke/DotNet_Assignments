using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsebBillInheritanceEX
{
    class Bill
    {
        private int BillNo;
        private string BillDate;
        private string CustomerName;

        public void AddBill(int bn,string bd,string cn)
        {
            this.BillNo = bn;
            this.BillDate = bd;
            this.CustomerName = cn;
        }
        public void DispBill()
        {
            Console.WriteLine("Bill No:"+ this.BillNo);
            Console.WriteLine("Bill Date:"+ this.BillDate);
            Console.WriteLine("Customer Name:"+ this.CustomerName);
        }
    }
    class MSEBBill:Bill
    {
        private int MeterNo;
        private int NoofUnits;
        private int RateperUnit;
        public void AddMsebBill(int mn,int nu,int ru,int bn,string bd,string cn)
        {
            AddBill(bn,bd,cn);
            this.MeterNo = mn;
            this.NoofUnits = nu;
            this.RateperUnit = ru;
        }
        public void DispMsebBill()
        {
            DispBill();
            Console.WriteLine("Meter No:"+ this.MeterNo);
            Console.WriteLine("No of Units:" + this.NoofUnits);
            Console.WriteLine("Rate per Unit:" + this.RateperUnit);
            Console.WriteLine("Bill Amount is:" + this.NoofUnits * this.RateperUnit);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MSEBBill MB = new MSEBBill();
            MB.AddMsebBill(12345,200,2,111, "8-11-2024", "Suresh Sharma");
            MB.DispMsebBill();
        }
    }
}
