using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            char[] charArray;

            Console.Write("Enter String:");
            a= Console.ReadLine();
            b = a;
            charArray=a.ToCharArray();
            Array.Reverse(charArray);
            b=new string(charArray);

            if(a.Equals(b))
            {
                Console.WriteLine("It is Palindrome String");
            }
            else
            {
                Console.WriteLine("It is not a Palindrome String");
            }
        }
    }
}
