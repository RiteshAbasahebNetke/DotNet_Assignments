using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelsediscountEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Qty;
            Console.Write("Enter Quantity:");
            Qty=Convert.ToInt32(Console.ReadLine());

            double Price, Amount, Discount;
            Console.Write("Enter Price:");
            Price=Convert.ToDouble(Console.ReadLine());

            string CityName;
            Console.Write("Enter CityName:");
            CityName=Console.ReadLine();
            Amount = Qty * Price;
            
            if(CityName=="Pune")
            {
                Discount = Amount * 0.2;
            }
            else
            {
                Discount = Amount * 0.1;
            }
        }
    }
}
