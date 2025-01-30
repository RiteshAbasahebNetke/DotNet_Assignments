using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfGivenNoEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sq;
            Console.Write("Enter No:");
            num=Convert.ToInt32(Console.ReadLine());
            sq = num * num;
            Console.WriteLine("Square is:"+  sq);   
        }
    }
}
