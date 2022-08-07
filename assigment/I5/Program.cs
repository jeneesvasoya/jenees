using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//I5. 0+1 + 1 + 2 + 3 + 5 + 8 + fibonacci

namespace I5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c,n,i=1;
            Console.WriteLine("enter the count of number in series");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("fibonacci.........");
            Console.WriteLine($"{a}");
            Console.WriteLine($"{b}");

            for(i=1;i<=n;i++)
            {
                c = a + b;
                Console.WriteLine($"{c}");
                a = b;
                b = c;
            }
            Console.Read();
        }
    }
}
