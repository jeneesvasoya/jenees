using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A14.Write a program to show details of 10 products including Product Name, Product Price, Qty to user and
//provide them ability to make order with qty and show final amount of bill.

namespace A14
{
    class product
    {
        string pro_name;
        int price;
        int pro_qty;

        internal void getdata()
        {
            Console.WriteLine("enter the product name ");
            pro_name = Console.ReadLine();

            Console.WriteLine("Enter the product price");
            price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the product qty");
            pro_qty= Convert.ToInt32(Console.ReadLine());
        }

        internal void showdata()
        {
            Console.WriteLine(" the product name is : {0}",pro_name);
            Console.WriteLine(" the product price is : {0}",price);
            Console.WriteLine("the product qty is : {0}",pro_qty);
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            product[] p = new product[2];

            for (int i = 0; i < 2; i++)
            {
                p[i] = new product();
                p[i].getdata();
            }
            for (int i = 0; i < 2; i++)
            {
                p[i].showdata();
            }
            Console.Read();
        }
    }
}
