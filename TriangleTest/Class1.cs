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
            int firstAngle = 10;
            int secondAngle = 10;
            int thirdAngle = 10;

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

        [Test]
        public void AnalyzeTriangle_Input10and14and16_OutputValidScaleneTriangle()
        {
            // Arrange
            int firstAngle = 10;
            int secondAngle = 14;
            int thirdAngle = 16;

            string expected = "A SCALENE triangle is formed";

            // Act
            string result = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void AnalyzeTriangle_Input12and28and33_OutputValidScaleneTriangle()
        {
            // Arrange
            int firstAngle = 12;
            int secondAngle = 28;
            int thirdAngle = 33;
            string expected = "A SCALENE triangle is formed";

            // Act
            string result = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void AnalyzeTriangle_Input7and9and13_OutputValidScaleneTriangle()
        {
            // Arrange
            int firstAngle = 7;
            int secondAngle = 9;
            int thirdAngle = 13;
            string expected = "A SCALENE triangle is formed";

            // Act
            string result = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void AnalyzeTriangle_Input8and12and13_OutputValidScaleneTriangle()
        {
            // Arrange
            int firstAngle = 8;
            int secondAngle = 12;
            int thirdAngle = 13;
            string expected = "A SCALENE triangle is formed";

            // Act
            string result = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void AnalyzeTriangle_Input14and15and16_OutputValidScaleneTriangle()
        {
            // Arrange
            int firstAngle = 14;
            int secondAngle = 15;
            int thirdAngle = 16;
            string expected = "A SCALENE triangle is formed";

            // Act
            string result = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual(expected, result);
        }
        
    }
}
