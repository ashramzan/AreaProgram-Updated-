using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaPerimeterProgram
{
    internal class Rectangle
    {
        public double AreaRectangle(double height, double width)
        {
            return height * width;
        }
        public double PerimeterRectangle(double height, double width)
        {
            return (2 * height) + (2 * width);
        }
    }
}
