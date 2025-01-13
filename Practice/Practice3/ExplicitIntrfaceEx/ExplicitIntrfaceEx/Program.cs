using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitIntrfaceEx
{
    interface AInt
    {
        void SayHello();
    }
    interface BInt
    {
        void SayHello();
    }

    class Message : AInt, BInt
    {
         void AInt.SayHello()
        {
            Console.WriteLine("AInt Called..!");
        }
        void BInt.SayHello()
        {
            Console.WriteLine("BInt Called..!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AInt a=new Message();
            a.SayHello();

            BInt b = new Message();
            b.SayHello();
        }
    }
}
