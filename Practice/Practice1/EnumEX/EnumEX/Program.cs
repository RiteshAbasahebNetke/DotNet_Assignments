using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumEX
{
    enum Category { Platinum=1,Diamond=2,Gold=3,Silver=4};
    internal class Program
    {
        static void Main(string[] args)
        {
            int CustomerCat;
            string ProductName;
            int Qty;
            double Price;
            Console.Write("Enter Customer Category:");
            CustomerCat=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Product Name:");
            ProductName=Console.ReadLine();
            Console.Write("Enter Quantity:");
            Qty=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Price:");
            Price=Convert.ToDouble(Console.ReadLine());

            double amount, discountamt;
            amount = Qty * Price;
            Console.WriteLine("Amount is:" + amount);
            switch (CustomerCat)
            {
                case (int)Category.Platinum:
                    discountamt = amount * 0.5;
                    break;
                    case(int)Category.Diamond:
                    discountamt= amount * 0.4;
                    break;
                    case(int)Category.Gold:
                    discountamt = amount * 0.3;
                    break;
                    case(int)Category.Silver:
                    discountamt = amount * 0.2;
                    break;
                default:
                    discountamt = amount * 0.1;
                    break;
            }
            Console.WriteLine("Discount Amount is:"+ discountamt);
        }
    }
}
