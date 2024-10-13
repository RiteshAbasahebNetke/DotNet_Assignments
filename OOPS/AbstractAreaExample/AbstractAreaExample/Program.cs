using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAreaExample
{
    abstract class Shape
    {
        public abstract double CalculateArea();
    }

    class Circle : Shape
    {
        private int r;
        public Circle(int r)
        {
            this.r = r;
        }
        public override double CalculateArea()
        {
            double a = 3.14 * r * r;
            return a;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(5);
            double a=c.CalculateArea();
            Console.WriteLine("Area of Circle is:" + a);
        }
    }
}
