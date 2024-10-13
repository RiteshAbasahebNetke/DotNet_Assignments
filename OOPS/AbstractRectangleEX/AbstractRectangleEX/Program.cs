using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractRectangleEX
{
    abstract class Shape
    {
        public abstract double CalulateArea();
    }
    class Rectangle : Shape
    {
        private int l, b;
        public Rectangle(int l, int b)
        {
            this.l = l;
            this.b = b;
        }

        public override double CalulateArea()
        {
            double a = l * b;
            return a;..
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(4, 5);
            double a=r.CalulateArea();
            Console.WriteLine("Area of Rectangle is:" + a);
        }
    }
}
