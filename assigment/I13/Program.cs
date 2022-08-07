using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//I13.Write a program to implement multilevel inheritance.
namespace I13
{
    class student
    {
        int rollnumber;
        protected void get1()
        {
            rollnumber = 1;
        }
        protected void show1()
        {
            Console.WriteLine("rollnumber is :" + rollnumber);
        }
    }
    class test : student
    {
        double sub1;
        double sub2, temp;

        protected void get2()
        {
            sub1 = 75.5;
            sub2 = 98.5;

        }
        protected double add()
        {
            temp = sub1 + sub2;
            return temp;
        }
        protected void show2()
        {
            Console.WriteLine("subject1 marks is :" + sub1);
            Console.WriteLine("subject2 marks is :" + sub2);
        }
    }
    class result : test
    {
        double total_marks;
        internal void getdata()
        {
            get1();
            get2();

            total_marks = add();
        }
        internal void showdata()
        {
            show1();
            show2();
            Console.WriteLine("total marks is :" + total_marks);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            result r1 = new result();
            r1.getdata();
            r1.showdata();

            Console.Read();
        }
    }
}
