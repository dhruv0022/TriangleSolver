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
            string result = Triangle.AnalyzeTriangle(firstAngle,secondAngle,thirdAngle);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
