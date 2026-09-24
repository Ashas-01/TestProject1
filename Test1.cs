using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;
using System;

namespace CalculatorApp.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_CorrectValues_ReturnsSum()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            int result = calculator.Add(5, 3);

            // Assert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Divide_ByZero_ThrowsException()
        {
            // Arrange
            var calculator = new Calculator();

            // Act & Assert
            try
            {
                calculator.Divide(10, 0);
                Assert.Fail("Ожидалось исключение DivideByZeroException, но оно не было выброшено");
            }
            catch (DivideByZeroException)
            {
                // Тест пройден — исключение выброшено правильно
            }
        }
    }
}