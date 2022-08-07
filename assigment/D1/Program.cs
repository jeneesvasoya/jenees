using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A1.Create program to replace specific character from string

namespace D1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "hello guys goodmorning";
            Console.WriteLine(name.Replace("guys","boys"));
            Console.Read();
        }
    }
}
