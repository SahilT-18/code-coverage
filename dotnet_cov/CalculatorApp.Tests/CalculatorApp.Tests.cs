// CalculatorApp.Tests/CalculatorTests.cs

using System;
using Xunit;
using CalculatorApp; // Ensure correct namespace reference

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            var calculator = new Calculator();
            Assert.Equal(8, calculator.Add(5, 3));
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            var calculator = new Calculator();
            Assert.Equal(2, calculator.Subtract(5, 3));
        }

        [Fact]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            var calculator = new Calculator();
            Assert.Equal(15, calculator.Multiply(5, 3));
        }

        [Fact]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            var calculator = new Calculator();
            Assert.Equal(3, calculator.Divide(6, 2));
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            var calculator = new Calculator();
            Assert.Throws<ArgumentException>(() => calculator.Divide(6, 0));
        }
    }
}
