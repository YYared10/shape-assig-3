using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    class Rectangle : Base
    {
        
        public double length { get; set; }
        public double Width { get; set; }
        // override the abstract methods
        public override double CalculateArea()
        {
            return (length * Width);
        }
        public override double CalculatePerimeter()
        {
            return 2 * (length + Width);
        }
    }
}
