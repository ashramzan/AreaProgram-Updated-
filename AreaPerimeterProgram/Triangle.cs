using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaPerimeterProgram
{
    internal class Triangle
    {
        public double AreaTriangle(double SideA, double SideB, double SideC)
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }
        public double PerimeterTriangle(double SideA, double SideB, double SideC)
        {
            double s = SideA + SideB + SideC;
            return s;
        }
    }
}
