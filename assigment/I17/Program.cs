using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I17
{
    class Box
    {
        private double length; 
        private double breadth; 
        private double height; 

        public void setLength(double len)
        {
            length = len;
        }

        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public void setHeight(double hei)
        {
            height = hei;
        }

        public double getVolume()
        {
            return length * breadth * height;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();
            Box1.setLength(6.0);
            Box1.setBreadth(7.0);
            Box1.setHeight(5.0);

            double volume;

             volume = Box1.getVolume();
            Console.WriteLine("Volume of Box1 : {0}", volume);

            Console.Read();
        }
    }
}
