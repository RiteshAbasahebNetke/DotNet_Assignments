using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceEx
{
    interface Aint
    {
        void SayHello();
    }
    interface Bint
    {
        void SayHello();
    }
    class Message : Aint, Bint
    {
        void Aint.SayHello()
        {
            Console.WriteLine("SayHello Aint Called..!");
        }
        void Bint.SayHello()
        {
            Console.WriteLine("SayHello Bint Called..!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Aint a=new Message();
            a.SayHello();

            Bint b=new Message();
            b.SayHello();
        }
    }
}
