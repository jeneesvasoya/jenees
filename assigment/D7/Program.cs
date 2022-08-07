using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A11.Write a program to Get 10 random numbers using parent class's constructor and implement one method in
//derived class to show them in ascending manner.

namespace D7
{
    class Myclass
    {
        Random r = new Random();
        protected int[] arr = new int[10];
        public Myclass()
        {
            for (int i = 0; i < 10; i++)
            {
                arr[i] = r.Next(1,100);
            }
        }
    }
    class Derived: Myclass
    {
        internal void display()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Array.Sort(arr);

            Console.WriteLine("sorting random number ...");

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
            d.display();

            Console.Read();
        }
    }
}
