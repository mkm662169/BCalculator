using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Helpers.Tests
{
    [TestClass()]
    public class ArrayTests
    {
        private readonly int[] arrayA = { 1, 2, 3, 4, 5 };
        private readonly double[] arrayB = { 1.1, 2.2, 3.3, 4.4, 5.5 };
        [TestMethod()]
        public void ArrayIntLengthTest()
        {
            Assert.AreEqual(5, Array.Length(arrayA));
        }

        [TestMethod()]
        public void ArrayDoubleLengthTest()
        {
            Assert.AreEqual(5, Array.Length(arrayB));
        }
    }
}