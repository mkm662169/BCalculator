using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatOperations;
using System;
using System.Collections.Generic;
using System.Text;
using Helpers;

namespace StatOperations.Tests
{
    [TestClass()]
    public class StatVarianceTests
    {
        [TestMethod()]
        public void VarianceIntTest()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            var variance = StatVariance.Variance(values);
            Assert.AreEqual(2, Helpers.Rounding.RoundToFive(variance));
        }

        [TestMethod()]
        public void VarianceTest2()
        {
            int[] values = { 17, 15, 23, 7, 9, 13 };
            var variance = StatVariance.Variance(values);
            Assert.AreEqual(27.67, Helpers.Rounding.RoundToTwo(variance));
        }
    }
}