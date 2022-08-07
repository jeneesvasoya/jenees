using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//B6.Explain any 5 string operation methods

namespace B6
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Learning to c#";

            Console.WriteLine(str.Length);
            Console.WriteLine(str.IndexOf("ing"));
            Console.WriteLine(str.Contains("ing"));
            Console.WriteLine(str.Insert(9,"ing "));
            Console.WriteLine(str.StartsWith("Le"));


            Console.Read();
        }
    }
}
