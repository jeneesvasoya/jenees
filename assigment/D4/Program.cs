using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A4.write a program to sort a numeric array without using array methods.
namespace D4
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] jd = new int[5];
            int temp;

            Console.WriteLine("enter the element of number :");

            for (int i = 0; i < 5; i++)
            {
                jd[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("array........");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("a[{0}] :{1}",i,jd[i]);
            }

            Console.WriteLine("sorting array.......");
            for (int i = 0; i < 5; i++)
            {
                for (int j = i+1; j < 5; j++)
                {
                    if(jd[i] >jd[j])
                    {
                        temp = jd[i];
                        jd[i] = jd[j];
                        jd[j] = temp;
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("a[{0}] : {1}",i,jd[i]);
            }
            Console.Read();
        }
    }
}
