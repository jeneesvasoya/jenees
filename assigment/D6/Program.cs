using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A8.Write a program to define base class with fixed method signature and implement them into derived class.
//(Abstract Class)

namespace D6
{
    class base1
    {
        virtual public void display()
        {
            Console.WriteLine("calling to base1");
        }
    }
    class driverd : base1
    {
        public override void display()
        {
            Console.WriteLine("calling to deriverd");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            base1 b = new driverd();
            b.display();
            Console.Read();
        }
    }
}
