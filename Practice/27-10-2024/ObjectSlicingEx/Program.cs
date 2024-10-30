using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectSlicingEx
{
    class Device
    {
        public virtual void Display()
        {
            Console.WriteLine("I am a device..!");
        }
    }
    class Xerox:Device
    {
        public override void Display()
        {
            Console.WriteLine("I am a Xerox");
        }
    }
    class Printer : Device
    {
        public override void Display()
        {
            Console.WriteLine("I am a Printer");
        }
    }
    class Monitor:Device
    {
        public override void Display()
        {
            Console.WriteLine("I am a Monitor");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Device d=new Device();
            Console.WriteLine("Enter 1 for Xerox:");
            Console.WriteLine("Ennter 2 for Printer:");
            Console.WriteLine("Enter 3 for Monitor:");
            Console.WriteLine("Enter Option:");
            int opt = Convert.ToInt32(Console.ReadLine());

            switch ("opt")
            {
                case "1": d = new Xerox();
                    break;
                case "2": d = new Printer();
                    break;
                case "3":d = new Monitor();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            d.Display();
        }
    }
}
