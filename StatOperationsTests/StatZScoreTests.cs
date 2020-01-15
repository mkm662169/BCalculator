using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatOperations.Tests
{
    [TestClass()]
    public class StatZScoreTests
    {
        private readonly int score = 2;
        private readonly double mean = 3.0;
        private readonly double stdDev = 1.87;

        [TestMethod()]
        public void ZScoreTest()
        {

            Assert.AreEqual(-0.53, Helpers.Rounding.RoundToTwo(StatZScore.ZScore(score, mean, stdDev)));
        }
    }
}