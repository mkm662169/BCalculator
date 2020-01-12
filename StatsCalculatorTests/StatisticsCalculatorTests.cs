using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StatsCalculator.Tests
{
    [TestClass()]
    public class StatisticsCalculatorTests
    {
        [TestMethod()]
        public void MeanTest()
        {
            StatisticsCalculator statsCalc = new StatisticsCalculator();
            int[] values = { 1, 2, 3, 4, 5 };
            var mean = statsCalc.Mean(values);
            Assert.AreEqual(3, mean);
        }
    }
}