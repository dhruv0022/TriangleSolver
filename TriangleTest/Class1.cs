using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TriangleTest
{
    public class Class1
    {
        [Test]
        public void AnalyzeTriangle_Input10and10and10_OutputValidEquilateralTriangle()
        {
            // Arrange
            int firstAngle = 5;
            int secondAngle = 5;
            int thirdAngle = 5;

            string expected = "An EQUILATERAL triangle is formed";

            // Act
            string result = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void AnalyzeTriangle_Input10and10and6_OutputValidIsoscelesTriangle()
        {
            // Arrange
            int firstAngle = 10;
            int secondAngle = 10;
            int thirdAngle = 6;
            string expected = "An ISOSCELES triangle is formed";

            // Act
            string result = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void AnalyzeTriangle_Input10and6and10_OutputValidIsoscelesTriangle()
        {
            // Arrange
            int firstAngle = 10;
            int secondAngle = 6;
            int thirdAngle = 10;
            string expected = "An ISOSCELES triangle is formed";

            // Act
            string result = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void AnalyzeTriangle_Input6and10and10_OutputValidIsoscelesTriangle()
        {
            // Arrange
            int firstAngle = 6;
            int secondAngle = 10;
            int thirdAngle = 10;
            string expected = "An ISOSCELES triangle is formed";

            // Act
            string result = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual(expected, result);
        }


    }
}
