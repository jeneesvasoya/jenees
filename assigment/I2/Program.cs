using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//I2.Create program to take 3 numbers from user and show maimum and minimum number

namespace I2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("enter the a is :");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the b is :");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the c is :");
            c = Convert.ToInt32(Console.ReadLine());

            //if (a>b)
            //{
            //    if (a>c)
            //    {
            //        Console.WriteLine("a is max :{0} ", a) ;
            //    }
            //    else
            //    {
            //        Console.WriteLine("c is max :{0}",c);
            //    }
            //}
            //else
            //{
            //    if (b>c)
            //    {
            //        Console.WriteLine("b is max :{0}",b);
            //    }
            //    else
            //    {
            //        Console.WriteLine("c is max :"+c);
            //    }
            //}

            if (a < b)
            {
                if (a < c)
                {
                    Console.WriteLine("a is min :{0} ", a);
                }
                else
                {
                    Console.WriteLine("c is min :{0}", c);
                }
            }
            else
            {
                if (b < c)
                {
                    Console.WriteLine("b is min :{0}", b);
                }
                else
                {
                    Console.WriteLine("c is min :" + c);
                }
            }
            Console.Read();
        }
    }
}
