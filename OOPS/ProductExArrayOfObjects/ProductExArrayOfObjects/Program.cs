﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductExArrayOfObjects
{
    public class Product
    {
        public int ProductID;
        public string ProductName;
        public string MfgName;
        public double Price;

        public void AddProduct(int pi,string pn, string mn,double p)
        {
            this.ProductID = pi;
            this.ProductName = pn;  
            this.MfgName = mn;
            this.Price = p;
        }
        public void DispProduct()
        {
            Console.WriteLine("Product ID:" + this.ProductID);
            Console.WriteLine("Product Name:" + this.ProductName);
            Console.WriteLine("MfgName is:" + this.MfgName);
            Console.WriteLine("Price:" + this.Price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] pr = new Product[3];
            int pi;
            string pn, mn;
            double p;

            for(int i=0; i<3; i++)
            {
                Console.Write("Enter ProductID:");
                pi=Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Product Name:");
                pn = Console.ReadLine();

                Console.Write("Enter MfgName:");
                mn = Console.ReadLine();

                Console.Write("Enter Price:");
                p=Convert.ToDouble(Console.ReadLine());

                pr[i] = new Product();
                pr[i].AddProduct(pi,pn,mn,p); 
            }
            Console.WriteLine();

            for (int i=0; i<3; i++)
            {
                pr[i].DispProduct();
            }
        }
    }
}