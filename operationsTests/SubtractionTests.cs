﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace operations.Tests
{
    [TestClass()]
    public class SubtractionTests
    {
        private readonly dynamic a = 40;
        private readonly dynamic b = 37;
        private readonly dynamic c = 6.7;
        private readonly dynamic d = 4.5;

        [TestMethod()]
        public void MinusTest()
        {
            Assert.AreEqual(3, Subtraction.Minus(a, b));
        }

        [TestMethod()]
        public void MinusDoubleTest()
        {
            Assert.AreEqual(2.2, Subtraction.Minus(c, d));
        }
    }
}