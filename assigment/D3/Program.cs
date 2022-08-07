using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A3.Write a program to find factorial of userdefined number

namespace D3
{1
    class Program
    {
        static void Main(string[] args)
        {
            int n,fac=1,i=1;
            Console.WriteLine("enter the number of factorial is :");
            n = Convert.ToInt32(Console.ReadLine());

            while (i<=n)
            {
                fac = fac * i;
                i++;
            }
            Console.WriteLine("factorial of {0} is : {1}",n,fac);
            Console.Read();
        }
    }
}
