using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxAmountex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Amount, TaxAmount;
            Console.Write("Enter Amount:");
            Amount=Convert.ToDouble(Console.ReadLine());

            string StateName;
            Console.Write("Enter StateName:");
            StateName=Console.ReadLine();

            if(StateName=="Goa")
            {
                TaxAmount = Amount * 0.05;
            }
            else
            {
                TaxAmount = Amount * 0.02;
            }

            Console.WriteLine("Tax Amount is:" + TaxAmount);
        }
    }
}
