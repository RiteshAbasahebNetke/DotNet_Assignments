using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int GetCapCount(this string obj)
            {
                int count = 0;
                for(int a=0;a<=obj.Length;a++)
                {
                    if(obj[a] == 'A' && obj[a]<='Z')
                        count++;
                }
                return count;
            }
        }
    }
}
