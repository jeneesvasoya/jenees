using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//I12.Write a program to call static method using class.

namespace I12
{
     class jd
    {
        static public string name;

        public static void details()
        {
            Console.WriteLine("The name  is:");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
             jd j1 = new jd();
            jd.name = "jenees";
            jd.details();
            Console.WriteLine("name  is : "+jd.name);
            Console.Read();

        }
    }
}
