using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    abstract class Base
    {

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
        static void Main(string[] args)
        {
            Circle c = new Circle();
            Rectangle r = new Rectangle();
            Console.WriteLine("Enter the radius ");
            c.radius = double.Parse(Console.ReadLine());

            Console.WriteLine("Area of the circle is " + c.CalculateArea());
            Console.WriteLine("Circumfrence of the circle is  " + c.CalculatePerimeter());



            Console.WriteLine("Enter the Length ");
            r.length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Width ");
            r.Width = double.Parse(Console.ReadLine());

            Console.WriteLine("Area of the Rectangle is " + r.CalculateArea());
            Console.WriteLine("Perimeter of the Rectangle is " + r.CalculatePerimeter());
            Console.ReadKey();

        }
    }
}

