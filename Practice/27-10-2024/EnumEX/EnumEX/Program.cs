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
            int CustomerCategory;
            string ProductName;
            int Qty;
            double Price;

            Console.Write("Enter Customer Category:");
            CustomerCategory=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Product Name:");
            ProductName=Console.ReadLine();

            Console.Write("Enter Quantity:");
            Qty=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Price:");
            Price=Convert.ToDouble(Console.ReadLine());

            double Amount, DiscountAmout = 0;
            Amount = Price * Qty;
            Console.WriteLine("Amount is:" + Amount);

            switch(CustomerCategory)
            {
                case(int)Category.Platinum:
                    DiscountAmout = Amount * 0.5;
                    break;
                    case(int)Category.Diamond:
                    DiscountAmout= Amount * 0.4;
                    break;
                    case(int)Category.Gold:
                    DiscountAmout = Amount * 0.3;
                    break;
                    case (int)Category.Silver:
                    DiscountAmout = Amount * 0.2;
                    break;
                    default:
                    DiscountAmout = Amount * 0.1;
                    break;
            }
            Console.WriteLine("Discount Amount is:"+DiscountAmout);
        }
    }
}
