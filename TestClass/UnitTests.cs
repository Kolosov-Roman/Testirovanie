using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Diagnostics.Metrics;
using UnitTestVar11;

namespace TestClass
{
    [TestClass]
    public class UnitTests
    {

        [TestMethod]
        public void Test1Path() //if x < 1 && c != 0
        {
            // Arrange
            double a = 1.5;
            double b = 2.0;
            double c = 3.5;
            double x = 0.5;
            double expression = a * x * x + (b / c);

            var counter = new MyCounter();

            // Act
            counter.Count(x, a, b, c);
            double real = counter.GetResult();

            // Assert
            Assert.AreEqual(expression, real, 0.001);
        }

        [TestMethod]
        public void Test2Path() //if x > 1.5 && c == 0
        {
            // Arrange
            double a = 1.5;
            double b = 2.0;
            double c = 0.0;
            double x = 2.0;
            double expression = (x - a) / ((x - c) * (x - c));

            var counter = new MyCounter();

            // Act
            counter.Count(x, a, b, c);
            double real = counter.GetResult();

            // Assert
            Assert.AreEqual(expression, real, 0.001);
        }

        [TestMethod]
        public void Test3Path() //if else x<1 && c==0
        {
            // Arrange
            double a = 1.5;
            double b = 2.0;
            double c = 0.0;
            double x = 0.5;
            double expression = (x * x) / (c * c);

            var counter = new MyCounter();

            // Act
            counter.Count(x, a, b, c);
            double real = counter.GetResult();

            // Assert
            Assert.AreEqual(expression, real, 0.001);
        }

        [TestMethod]
        public void Test4Path() //else x > 1.5 && c != 0
        {
            // Arrange
            double a = 1.5;
            double b = 2.0;
            double c = 1.0;
            double x = 2.5;
            double expression = (x * x) / (c * c);

            var counter = new MyCounter();

            // Act
            counter.Count(x, a, b, c);
            double real = counter.GetResult();

            // Assert
            Assert.AreEqual(expression, real, 0.001);
        }

        [TestMethod]
        public void Test5Path() //if x < 1 && c != 0, but false: c=0
        {
            // Arrange
            double a = 1.5;
            double b = 2.0;
            double c = 0.0;
            double x = 0.5;
            double expression = a * x * x + (b / c);

            var counter = new MyCounter();

            // Act
            counter.Count(x, a, b, c);
            double real = counter.GetResult();

            // Assert
            Assert.AreNotEqual(expression, real, 0.001);
        }
    }
}