using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//I16.Write a program to redefine method logic in child class. (Overloading)
namespace I16
{
    class GFG
    {


        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }


        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GFG g1 = new GFG();
            int jd = g1.Add(10, 20);
            Console.WriteLine("sum is :"+jd);

            int jd1 = g1.Add(10,30, 20);
            Console.WriteLine("3 number sum is :" + jd1);
            Console.Read();
        }
    }
}
