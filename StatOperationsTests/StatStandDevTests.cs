using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatOperations.Tests
{
    [TestClass()]
    public class StatStandDevTests
    {
        [TestMethod()]
        public void StandDevTest()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            var standDev = StatStandDev.StandDev(values);
            Assert.AreEqual(1.41421, Helpers.Rounding.RoundToFive(standDev));
        }
    }
}