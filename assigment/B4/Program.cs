using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//B4.Create a program to differentiate explicit and implicit conversation.

namespace B4
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit
            int a = 75;
            long j = a;

            //explicit
            double k = 75.5;
            int i;
            i = (int)k;
        }
    }
}
