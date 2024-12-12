using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Set_Prop_ProductEX
{
    class Product
    {
        private int ProductID;
        private string ProductName;
        private string MfgName;
        public double Price;
        public double ProPrice
        {
            get { return Price; }
        }
        public Product(int pid,string pn,string mn,double p)
        {
            this.ProductID = pid;
            this.ProductName = pn;
            this.MfgName = mn;
            this.Price = p;
        }
        public void DispProduct()
        {
            Console.WriteLine("ProductID is:"+ this.ProductID);
            Console.WriteLine("Product Name is:" + this.ProductName);
            Console.WriteLine("Mfg Name is:"+ this.MfgName);
            Console.WriteLine("Price is:"+ this.Price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> pr = new List<Product>();
            int pid;
            string pn, mn;
            double p;
            for(int i=0;i<3;i++)
            {
                Console.Write("Enter ProductID:");
                pid = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter ProductName:");
                pn=Console.ReadLine();
                Console.Write("Enter MfgName:");
                mn=Console.ReadLine();
                Console.Write("Enter Price:");
                p=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                pr.Add(new Product(pid,pn,mn,p));
            }
            foreach(Product temp in pr)
            {
                if(temp.ProPrice>500)
                {
                    temp.DispProduct();
                }
            }
        }
    }
}
