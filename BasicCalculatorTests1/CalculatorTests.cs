using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        private readonly Calculator calculator = new Calculator();
        [TestMethod()]
        public void AddTest()
        {
            dynamic c = calculator.Add(30, 47);

            Assert.AreEqual(77, c);
            Assert.AreEqual(77, calculator.solution);
        }
        [TestMethod()]
        public void AddIntDoubleTest()
        {
            dynamic c = calculator.Add(2, 2.43);

            Assert.AreEqual(4.43, c);
            Assert.AreEqual(4.43, calculator.solution);
        }

        /*[TestMethod()]
        public void AddDoubleArrayTest()
        {
            double a = 1.1;
            double b = 2.2;
            double[] values = { a, b };

            double c = calculator.Add(values);

            Assert.AreEqual(3.2, calculator.solution);
        }*/
        [TestMethod()]
        public void AddArrayIntTest()
        {
            Calculator calculator = new Calculator();
            int[] values = { 1, 2 };

            int c = calculator.Add(values);

            Assert.AreEqual(3, c);
            Assert.AreEqual(3, calculator.solution);
        }

        [TestMethod()]
        public void DivideTest()
        {
            int d = calculator.Divide(70, 35);

            Assert.AreEqual(2, d);
            Assert.AreEqual(2, calculator.solution);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            int c = calculator.Multiply(8, 5);

            Assert.AreEqual(40, c);
            Assert.AreEqual(40, calculator.solution);
        }
    }
}