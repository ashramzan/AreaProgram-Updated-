using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaPerimeterProgram
{
    internal class Circle
    {
        double pi = Math.PI;
        public double AreaCircle(double radius)
        {
            return pi * (radius * radius);
        }
        public double PerimeterCircle(double radius)
        {
            return 2 * pi * radius;
        }
    }
}
