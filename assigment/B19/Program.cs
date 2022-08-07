using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//B19.Write a program to calculate factorial number of userdefined value using class.

namespace B19
{
    class Program
    {
        static void Main(string[] args)
        {
            factorial f1 = new factorial();
            f1.fac();
            f1.show();
            Console.Read();
        }
    }
}
