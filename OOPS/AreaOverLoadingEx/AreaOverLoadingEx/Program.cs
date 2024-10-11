using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOverLoadingEx
{
    public class Shape
    {
        public int l;
        public int b;
        public int r;

        public void CalculateArea(int r)
        {
            double a = 3.14 * r * r;
            Console.WriteLine("Area of Circle:" + a);
        }
        public void CalculateArea(int l, int b)
        {
            double a = l * b;
            Console.WriteLine("Area of Rectangle:" + a);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s=new Shape();
            s.CalculateArea(2);
            s.CalculateArea(2, 2);
        }
    }
}
