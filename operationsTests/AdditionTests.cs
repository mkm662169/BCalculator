using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace operations.Tests
{
    [TestClass()]
    public class AdditionTests
    {
        private readonly dynamic a = 5;
        private readonly dynamic b = 10;
        private readonly dynamic c = 5.7;
        private readonly dynamic d = 4.5;
        private readonly dynamic[] arrayA = { 1, 2, 3, 4 };
        private readonly dynamic[] arrayB = { 1.1, 2.2, 3.3, 4.2 };

        [TestMethod()]
        public void AddTest()
        {
            Assert.AreEqual(15, Addition.Add(a, b));
        }

        [TestMethod()]
        public void AddDoubleTest()
        {
            Assert.AreEqual(10.2, Addition.Add(c, d));
        }

        [TestMethod()]
        public void AddArrayTest()
        {
            Assert.AreEqual(10, Addition.Add(arrayA));
        }

        [TestMethod()]
        public void AddDoubleArrayTest()
        {
            Assert.AreEqual(10.8, Addition.Add(arrayB));
        }
    }
}