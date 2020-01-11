using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace operations.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        private readonly int a = 55;
        private readonly int b = 5;
        private readonly double c = 5.7;
        private readonly double d = 2.4;
       // private readonly int[] arrayA = { 1, 3, 7, 9, 18 };
        private readonly int e = 0;

        [TestMethod()]
        public void DivideTest()
        {
            Assert.AreEqual(11, Division.Divide(a, b));
        }

        [TestMethod()]
        public void DivideDoubleTest()
        {
            Assert.AreEqual(2.375, Division.Divide(c, d));
        }

       /* [TestMethod()]
        public void DivideArrayTest()
        {
            Assert.AreEqual(38, )
        }*/

        [TestMethod()]
        public void DivideByZeroTest()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Division.Divide(a, e));
            /*double d = Division.Divide(a, e);
            Assert.IsTrue(double.IsInfinity(d));
            Assert.IsTrue(double.IsInfinity(Division.Divide(a, e)));*/
        }
    }
}