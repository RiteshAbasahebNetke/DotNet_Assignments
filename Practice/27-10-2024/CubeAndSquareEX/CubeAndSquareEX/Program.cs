using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeAndSquareEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, cu,m,sq;
            Console.Write("Enter No:");
            n = Convert.ToInt32(Console.ReadLine());
            cu = n * n * n;
            Console.WriteLine("Cube is:" + cu);

            Console.Write("Enter No:");
            m = Convert.ToInt32(Console.ReadLine());
            sq= m * m;  
            Console.WriteLine("Square is:"+ sq);
        }
    }
}
