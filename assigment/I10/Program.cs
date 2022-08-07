using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//I10.Create program to make transpose of two matrices

namespace I10
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, c;
            int[,] jd = new int[50, 50];
            Console.WriteLine("array matrix.....");

            Console.WriteLine("enter the row of number is:");
            r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the colum of number is:");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter  element...");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    jd[i,j]= Convert.ToInt32(Console.ReadLine());
                }
               
            }
            Console.WriteLine("show  element...");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(" "+jd[i,j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("transpose matrix..");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(" "+jd[j, i]);
                }
                Console.WriteLine();
            }


            Console.Read();
        }
    }
}
