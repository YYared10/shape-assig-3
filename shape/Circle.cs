using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
     class Circle : Base
    {
        // pi 
        static double PI = 3.1415;
        // get and set on var (radius )
        public double radius { get; set; }
        // override the abstract methods
        public override double CalculateArea()
        {
            return (radius * radius) * PI;
        }
        public override double CalculatePerimeter()
        {
            return 2 * (PI * radius);
        }
    }
}
