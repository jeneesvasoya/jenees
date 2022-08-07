using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A12.Write a program to prevent class from being instantiated.

namespace A12
{
    static class jd
    {
        static public int a = 10;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //jd.a = 50;
            Console.WriteLine(jd.a);
            Console.Read();
        }
    }
}
