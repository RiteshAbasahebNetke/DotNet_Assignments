using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NormalEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, cube;
            Console.Write("Enter Number:");
            num=Convert.ToInt32(Console.ReadLine());
            cube = num * num * num;
            Console.WriteLine("Cube is:"+ cube);

            Console.WriteLine("*********************************************");

            int n, s;
            Console.Write("Enter Number:");
            n= Convert.ToInt32(Console.ReadLine());
            s = n * n;
            Console.WriteLine("Square is:"+ s);

            Console.WriteLine("*********************************************");

            int no;
            Console.Write("Enter Number:");
            no=Convert.ToInt32(Console.ReadLine());
            if (no % 2 == 0) { Console.WriteLine("Number is even...!"); }
            else { Console.WriteLine("Number is odd...!"); }
        }
    }
}
