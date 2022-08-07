using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//I8.Explain 5 method of array class with example

namespace I8
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] jdvasoya =new char[] { 'A', 'K', 'I', 'B', 'D' };

            //Array.Sort(jdvasoya);
            //foreach (char sorting in jdvasoya)
            //{
            //    Console.WriteLine(sorting + " ");
            //}

            //Array.Reverse(jdvasoya);
            //foreach (char rev in jdvasoya)
            //{
            //    Console.WriteLine(rev + " ");
            //}

            Array.BinarySearch(jdvasoya, 4);
            foreach (char se in jdvasoya)
            {
                Console.WriteLine(se+" ");
            }
            Console.Read();
        }
    }
}
