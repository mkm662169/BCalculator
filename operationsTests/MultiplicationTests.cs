using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace operations.Tests
{
    [TestClass()]
    public class MultiplicationTests
    {
        private readonly dynamic a = 5;
        private readonly dynamic b = 7;
        private readonly dynamic c = 5.7;
        private readonly dynamic d = 8.3;
        private readonly dynamic[] arrayA = { 1, 2, 3, 4 };
        private readonly dynamic[] arrayB = { 1.1, 2.2, 3.3, 4.4 };

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.AreEqual(35, Multiplication.Multiply(a, b));
        }

        [TestMethod()]
        public void MultiplyDoubleTest()
        {
            Assert.AreEqual(47.31, Multiplication.Multiply(c, d));
        }

        [TestMethod()]
        public void MultiplyArrayTest()
        {
            Assert.AreEqual(24, Multiplication.Multiply(arrayA));
        }

        [TestMethod()]
        public void MultiplyDoubleArrayTest()
        {
            Assert.AreEqual(35.138400000000004, Multiplication.Multiply(arrayB));
        }
    }
}