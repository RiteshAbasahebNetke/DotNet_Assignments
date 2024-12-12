using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericEX
{   
    class Search<T>
    {
        public bool doSearch(T[] data,T d)
        {
            bool result=false;
            foreach(T temp in data)
            {
                if(temp.Equals(d))
                {
                    result=true;
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
            Search<int> s=new Search<int>();
            int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            if(s.doSearch(data,100))
            {
                Console.WriteLine("Integer Found..!");
            }
            else
            {
                Console.WriteLine("Integer not Found..!");
            }

            Search<string> se=new Search<string>();
            string[] name = { "Sujit", "Suresh", "Sham", "Shailesh" };

            if(se.doSearch(name, "Sham"))
            {
                Console.WriteLine("Name Found..!");
            }
            else
            {
                Console.WriteLine("Name not Found..!");
            }
        }
    }
}
