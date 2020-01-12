using StatsCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StatsCalculator.Tests
{
    [TestClass()]
    public class StatisticsCalculatorTests
    {
        private readonly StatisticsCalculator statsCalc = new StatisticsCalculator();

        [TestMethod()]
        public void MeanTest()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            var mean = statsCalc.Mean(values);
            Assert.AreEqual(3, mean);
        }

        [TestMethod()]
        public void VarianceTest()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            var variance = statsCalc.Variance(values);
            Assert.AreEqual(2, variance);
        }

        [TestMethod()]
        public void StandDevTest()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            var stdv = statsCalc.StandDev(values);
            Assert.AreEqual(1.41421, Helpers.Rounding.RoundToFive(stdv));
        }
    }
}