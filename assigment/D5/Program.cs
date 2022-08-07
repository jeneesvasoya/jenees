using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A7.Get 5 values from user and show maximum value from array

namespace D5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] jd = new int[5];
            int max=0,min=0;
            Console.WriteLine("enter the element of number :");

            for (int i = 0; i < 5; i++)
            {
                jd[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("array........");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("a[{0}] :{1}", i, jd[i]);
            }

            for (int i = 0; i < 5; i++)
            {
                if(jd[i]>max)
                {
                    max = jd[i];
                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (jd[i] <min )
                {
                    min = jd[i];
                }
            }

            Console.WriteLine("the min value is : {0}",min);
            Console.WriteLine("the max value is : {0}",max);
            Console.Read();
        }
    }
}
