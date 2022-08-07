using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B19
{
    class factorial
    {
        private int num;
        private int  fac1=1;

        public void fac()
        {
            Console.WriteLine("enter your number is :");
            num = Convert.ToInt32(Console.ReadLine());

            if(num==0 || num==1)
            {
                fac1 = 1;
            }

            else
            {
                while (num > 0)
                {
                    fac1 = fac1 * num;
                    num--;
                }
            }
            
        }
        public void show()
        {
            Console.WriteLine("factorial is {0}", fac1);
        }

    }
}
