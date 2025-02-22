using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleAreaInterfaceEX
{
    interface AreaInt
    {
        double CalculateArea();
    }
    class Rectangle : AreaInt
    {
        private int l, b;
        public Rectangle(int l,int b)
        {
            this.l = l;
            this.b = b;
        }
        public double CalculateArea()
        {
            double area = l * b;
            return area;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(5, 5);
            double area = r.CalculateArea();
            Console.WriteLine("Area of Rectangle is:" + area);
        }
    }
}
