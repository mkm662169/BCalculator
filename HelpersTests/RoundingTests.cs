using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Helpers.Tests
{
    [TestClass()]
    public class RoundingTests
    {
        private readonly double num = 10.25840000000005;
        private readonly double x = 1.874359847034;
        private readonly double y = 6.89745890475;
        [TestMethod()]
        public void DecimalLengthTest()
        {
            Assert.AreEqual(10.26, Rounding.RoundToTwo(num));
        }

        [TestMethod()]
        public void RoundToFourTest()
        {
            Assert.AreEqual(1.8744, Rounding.RoundToFour(x));
        }

        [TestMethod()]
        public void RoundToFiveTest()
        {
            Assert.AreEqual(6.89746, Rounding.RoundToFive(y));
        }
    }
}