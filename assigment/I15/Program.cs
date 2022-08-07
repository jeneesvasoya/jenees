using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//I15.Write a program to implement multiple inheritance

namespace I15
{
    class A
    {
        public A()
        {
            Console.WriteLine("Mammals can give direct birth.");
        }

    }
    class B
    {
        public B()
        {
            Console.WriteLine("Winged animal can flap.");
        }
    }
    class Child : A,B
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
