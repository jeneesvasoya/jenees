using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//pattern
//1
//23
//456
//78910

namespace A1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j,c=1;
            for(i=1;i<=4;i++)
            {
                for(j=1;j<=i;j++)
                {
                    
                    Console.Write($"{c}");
                    c = c + 1;
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
