using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//I9.Get 5 values from user and store in array and show all elements and sum of elements

namespace I9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] jd = new int[5];

            int sum = 0;

            Console.WriteLine("enter the element of array:");
            for (int i = 0; i < jd.Length; i++)
            {
                jd[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("element is :...");
            for (int i = 0; i < jd.Length; i++)
            {
          
                Console.WriteLine("a[{0}] is :{1}",i,jd[i]);
            }
            Console.WriteLine("sum is ....");
            for (int i = 0; i < jd.Length; i++)
            {
                sum = sum + jd[i];
               
            }
            Console.WriteLine("sum : "+sum);
            Console.Read();

        }
    }
}
