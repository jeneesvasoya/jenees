using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B16
{
    class Program
    {
        static void Main(string[] args)
        {
            arithmatic a1 = new arithmatic();
            a1.setdata(10, 2);

            a1.Add();
            a1.Div();
            a1.Mul();
            a1.Sub();

            Console.Read();
        }
    }
}
