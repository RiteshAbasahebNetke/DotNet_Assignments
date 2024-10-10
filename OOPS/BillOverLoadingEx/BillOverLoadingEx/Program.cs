using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillOverLoadingEx
{
    public class MobileBill
    {
        private string MobileNumber;
        private int NoofCalls;
        private double CallRate;

        public void addMobileBill(string mn,int nc,double cr)
        {
            this.MobileNumber = mn;
            this.NoofCalls = nc;
            this.CallRate = cr;
        }

        public void dispMobileBill()
        {
            Console.WriteLine("Mobile Nummber:"+ this.MobileNumber);
            Console.WriteLine("NoofCalls:" + this.NoofCalls);
            Console.WriteLine("Call Rate:" + this.CallRate);
            Console.WriteLine("Amount of Mobile bill:" + this.NoofCalls * this.CallRate);
        }
    }

    public class MsebBill
    {
        private int MeterNo;
        private int NoofUnits;
        private double RateperUnit;

        public void addMsebBill(int me,int num, double ru)
        {
            this.MeterNo = me;
            this.NoofUnits = num;
            this.RateperUnit = ru;
        }

        public void dispMsebBill()
        {
            Console.WriteLine("Meter No:" + this.MeterNo);
            Console.WriteLine("NoofUnits:" + this.NoofUnits);
            Console.WriteLine("RateperUnit:" + this.RateperUnit);
            Console.WriteLine("Amount of Mseb Bill:" + this.NoofUnits * this.RateperUnit);
        }
    }

    public class Bill
    {
        private int BillNo;
        private string CustomerName;
        private string BillDate;

        public void addBill(int bn, string cn, string bd)
        {
            this.BillNo = bn;
            this.CustomerName = cn;
            this.BillDate = bd;
        }

        public void dispBill()
        {
            Console.WriteLine("Bill No:" + this.BillNo);
            Console.WriteLine("Customer Name:" + this.CustomerName);
            Console.WriteLine("BillDate:" + this.BillDate);
        }

        public void displayBill(Bill b,MobileBill mb)
        {
            Console.WriteLine("*****************Mobile Bill****************");
            b.dispBill();
            mb.dispMobileBill();
        }

        public void displayBill(Bill b,MsebBill msb)
        {
            Console.WriteLine("*****************MSEB Bill****************");
            b.dispBill();
            msb.dispMsebBill();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int bn, nc, me, num;
            string cn, mn, bd;
            double cr, ru;

            Console.Write("Enter Bill Number:");
            bn=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Customer Name:");
            cn = Console.ReadLine();

            Console.Write("Enter BillDate:");
            bd=Console.ReadLine();

            Console.Write("Enter MobileNo:");
            mn= Console.ReadLine();

            Console.Write("Enter NoOfCalls:");
            nc=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter CallRate:");
            cr=Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter MeterNo:");
            me=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter NoOfUnits:");
            num=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter RateperUnit:");
            ru=Convert.ToDouble(Console.ReadLine());

            MobileBill mb = new MobileBill();
            mb.addMobileBill(mn, nc, cr);

            MsebBill msb = new MsebBill();
            msb.addMsebBill(me, num, ru);

            Bill b = new Bill();
            b.addBill(bn, cn, bd);

            b.displayBill(b, mb);
            b.displayBill(b,msb);
        }
    }
}
