using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace operations.Tests
{
    [TestClass()]
    public class SquareTests
    {
        private readonly dynamic a = 9;
        private readonly dynamic b = 1.1;

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