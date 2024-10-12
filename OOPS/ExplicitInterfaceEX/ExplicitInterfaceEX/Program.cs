using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceEX
{
    interface Aint
    {
        void SayHello();
    }
    interface Bint
    {
        void SayHello();
    }
    class Message:Aint,Bint
    {
        void Aint.SayHello()
        {
            Console.WriteLine("Say Hello for Aint...!");
        }
        void Bint.SayHello()
        {
            Console.WriteLine("Say Hello for Bint...!");
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
