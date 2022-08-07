using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//B5.Create program to sort string in descending order

namespace B5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] {"A","Z","R","D","B"};

            Array.Sort(arr);

            foreach (string g in arr)
            {
                Console.WriteLine(g);
            }
            Console.Read();

        }
    }
}
