using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMultipleTypeEX
{
    class Sample<A, B, C, D>
    {
        public void display(A a,B b,C c,D d)
        {
            Console.WriteLine("Value of a is:" + a);
            Console.WriteLine("Value of b is:" + b);
            Console.WriteLine("Value of c is:" + c);
            Console.WriteLine("Value of d is:" + d);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample<int, string, double, bool> s = new Sample<int, string, double, bool>();
                s.display(25, "Sham", 35.85, true);

            Console.WriteLine();

            Sample<int, string, int, string> s1 = new Sample<int, string, int, string>();
            s1.display(54, "First", 63, "Second");
            
        }
    }
}
