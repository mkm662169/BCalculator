using Microsoft.VisualStudio.TestTools.UnitTesting;
using operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace operations.Tests
{
    [TestClass()]
    public class RandomisingTests
    {
        private readonly int min = 10;
        private readonly int max = 30;
        Randomising rand = new Randomising();
        Randomising rand1 = new Randomising();

        [TestMethod()]
        public void RandomiseTest()
        {
            Assert.AreEqual(rand.Randomise(min, max), rand1.Randomise(min, max));
        }
    }
}