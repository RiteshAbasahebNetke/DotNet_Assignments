using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitInterfaceEX
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
        public void SayHello()
        {
            Console.WriteLine("Say Hello Called...!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Message m = new Message();
            m.SayHello();
        }
    }
}
