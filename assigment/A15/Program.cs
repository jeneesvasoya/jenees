using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A15.Create a program to store students details using Dictionaty

namespace A15
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> disc = new Dictionary<string, object>();
            disc.Add("ID", 1);
            disc.Add("name", "jdvasoya");
            disc.Add("email", "j@gmail.com");
            disc.Add("salary", 50005.25);
            disc.Add("gender", 'm');

            foreach (var item in disc)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
            Console.Read();
        }
    }
}
