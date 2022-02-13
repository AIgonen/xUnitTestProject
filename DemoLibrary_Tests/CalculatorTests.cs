using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;
using Xunit;

namespace DemoLibrary_Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(3, 4, 7)]
        [InlineData(20, 4.5, 24.5)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        public void Add_SimpleValiesShouldCalculate(double x, double y, double expected)
        {
            //Arrange
            
            //Act
            double actual = Calculator.Add(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 4, 2)]
        public void Divide_SimpleValiesShouldCalculate(double x, double y, double expected)
        {
            double actual = Calculator.Divide(x, y);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 4, 4)]
        [InlineData(8, 0, 8)]
        public void Subtract_SimpleValiesShouldCalculate(double x, double y, double expected)
        {
            double actual = Calculator.Subtract(x, y);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(2, 0, 0)]
        [InlineData(2, -1, -2)]
        public void Multiply_SimpleValiesShouldCalculate(double x, double y, double expected)
        {
            double actual = Calculator.Multiply(x, y);
            Assert.Equal(expected, actual);
        }
    }
}
