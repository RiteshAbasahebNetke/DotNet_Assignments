using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericEx
{
    class Search<T>
    {
        public bool doSearch(T[] data, T d)
        {
            bool result = false;
            foreach(T temp in data)
            {
                if (temp.Equals(d))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Search<int> s = new Search<int>();
            int[] data = { 12, 23, 54, 69, 87, 25, 30 };
            if (s.doSearch(data, 25))
            {
                Console.WriteLine("Number found");
            }
            else
            {
                Console.WriteLine("Number not found");
            }

            Search<string> str = new Search<string>();
            string[] names = { "Ram", "Sham", "Krushna", "Krishna" };
            if (str.doSearch(names, "Raj"))
            {
                Console.WriteLine("String found");
            }
            else
            {
                Console.WriteLine("String not found");
            }
        }
    }
}
