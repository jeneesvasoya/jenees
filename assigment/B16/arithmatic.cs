using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B16
{
    class arithmatic
    {
        private int a;
        private int b;

        public void setdata(int a,int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Add()
        {
            Console.WriteLine("addition is {0}", a + b);
        }
        public void Sub()
        {
            Console.WriteLine("subtraction is {0}", a - b);
        }
        public void Mul()
        {
            Console.WriteLine("multipication is {0}", a * b);
        }
        public void Div()
        {
            Console.WriteLine("divsion is {0}", a / b);
        }

    }
}
