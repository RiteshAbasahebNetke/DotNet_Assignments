using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingEx
{
    class Point
    {
        private int x;
        private int y;
        public void intPoint(int a,int b)
        {
            this.x = a;
            this.y = b;
        }
        public void dispPoint()
        {
            Console.WriteLine("X:" + this.x);
            Console.WriteLine("Y:" + this.y);
        }
        public static Point operator ++(Point t)
        {
            t.x++;
            t.y++;
            return t;
        }
        public static Point operator --(Point t)
        {
            t.x--;
            t.y--;
            return t;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p=new Point();
            p.intPoint(10, 20);
            p++;
            p.dispPoint();

            Point p1 = new Point();
            p1.intPoint(10, 20);
            p1.dispPoint();
            p1--;
        }
    }
}
