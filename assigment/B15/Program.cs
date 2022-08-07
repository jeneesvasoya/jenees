using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//B15.Write a program to call class method.
namespace B15
{
    class Program
    {
        static void Main(string[] args)
        {
            jd jems = new jd();
            Console.WriteLine(jems.name);
            Console.WriteLine(jems.id);

            Console.Read();
        }
    }
}
