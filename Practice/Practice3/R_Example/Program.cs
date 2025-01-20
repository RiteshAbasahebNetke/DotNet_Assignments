using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Practice
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, dig, rno=0;
            Console.Write("Enter Number:");
            num = Convert.ToInt32(Console.ReadLine());

            while (num > 0)
            {
                dig = num % 10;
                rno = dig+(rno*10);
                num = num / 10;
            }
            Console.WriteLine("Sum of digits is:" + rno);
        }
    }
}
