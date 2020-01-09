using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        private Calculator Calculator = new Calculator();
        [TestMethod()]
        public void AddTest()
        {
            int c = Calculator.Add(30, 47);

            Assert.AreEqual(77, c);
            Assert.AreEqual(77, Calculator.solution);
        }
    }
}