using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//B12.Show ASCII value of entered number

namespace B12
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;
            Console.WriteLine("enter the charcater :");
            a =Convert.ToChar (Console.ReadLine());

            int ascii = a;

            Console.WriteLine($"ascii value is {ascii} ");
            Console.Read();
        }
    }
}
