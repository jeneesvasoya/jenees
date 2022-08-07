using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I14
{
    class employee
    {
        string[] name = new string[10];
        int[] salary = new int[10];
        string[] depatment = new string[10];

        public void getdata()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("enter the name of employee {0} is {1}",i+1);
                name[i] = Console.ReadLine();

                Console.WriteLine("enter the salary of employee {0} is {1}", i + 1);
                salary[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter department of employee {0} is {1}", i + 1);
                depatment[i] = Console.ReadLine();
            }
        }

        public void show()
        {
            for (int i = 0; i < 10; i++)
            {
                if(salary[i] > 10000)
                {
                    Console.WriteLine(" employee of number is :{0} ",i+1);
                    Console.WriteLine("name is :"+name[i]);
                    Console.WriteLine("salary is :"+salary[i]);
                    Console.WriteLine("department is :"+depatment[i]);
                }
                else
                {
                    Console.WriteLine("the salary  is lowest");
                }
            }
        }
     }
    class Program
    {
        static void Main(string[] args)
        {
            employee e1 = new employee();
            e1.getdata();
            e1.show();

            Console.Read();
        }
    }
}
