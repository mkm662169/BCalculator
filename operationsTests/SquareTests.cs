using Microsoft.VisualStudio.TestTools.UnitTesting;
using operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace operations.Tests
{
    [TestClass()]
    public class SquareTests
    {
        private readonly int a = 9;
        private readonly double b = 1.1;

        [TestMethod()]
        public void SquaredTest()
        {
            Assert.AreEqual(81, Square.Squared(a));
        }

        [TestMethod()]
        public void SquaredTest1()
        {
            Assert.AreEqual(1.2100000000000002, Square.Squared(b));
        }
    }
}