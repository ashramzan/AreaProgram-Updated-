using AreaPerimeterProgram;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasPerimeterProgram
{
    [TestFixture]
    internal class Calc
    {
        [Test]
        [TestCase(8, 8, 8, 27.71)]
        public void ChecksSides_Calculates_AreaOfTriangle(double SideA, double SideB, double SideC, double expectedValue)
        {
            Triangle c = new Triangle();
            double actualValue = Math.Round(c.AreaTriangle(SideA, SideB, SideC), 2);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        [TestCase(10, 10, 8, 28)]
        public void ChecksSides_Calculates_PerimeterOfTriangle(double SideA, double SideB, double SideC, double expectedValue)
        {
            Triangle c = new Triangle();
            double actualValue = Math.Round(c.PerimeterTriangle(SideA, SideB, SideC), 2);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        [TestCase(5, 78.54)]
        public void ChecksRadius_Calculates_AreaOfCircle(double input, double expectedValue)
        {
            Circle c = new Circle();
            double radius = (input);
            double actualValue = Math.Round(c.AreaCircle(radius), 2);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        [TestCase(5, 31.42)]
        public void ChecksRadius_Calculates_PerimeterOfCircle(double input, double expectedValue)
        {
            Circle c = new Circle();
            double radius = (input);
            double actualValue = Math.Round(c.PerimeterCircle(radius), 2);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        [TestCase(8, 5, 40)]
        public void ChecksHeight_Width_Calculates_AreaOfRectangle(double height, double width, double expectedValue)
        {
            Rectangle c = new Rectangle();
            double actualValue = c.AreaRectangle(height, width);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        [TestCase(8, 5, 26)]
        public void ChecksHeight_Width_Calculates_PerimeterOfRectangle(double height, double width, double expectedValue)
        {
            Rectangle c = new Rectangle();
            double actualValue = c.PerimeterRectangle(height, width);
            Assert.AreEqual(expectedValue, actualValue);
        }

    }
}
