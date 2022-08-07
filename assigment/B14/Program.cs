using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//B14.Create program to iterate string variable using foreach loop

namespace B14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>();
            li.Add("jdvasoya");
            li.Add("bhavik");
            li.Add("variya");
            li.Add("power");
            li.Add("adani");

            foreach (var item in li)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
