using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A4.1+5+14+30+55...

namespace AI
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int sum = 0;
                Console.Write("N : ");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    sum = sum + i * i;
                    Console.WriteLine(sum);
                }
                Console.Read();
            }
        }
    }
}

