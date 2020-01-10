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
        /*[TestMethod()]
        public void AddIntDoubleTest()
        {
            dynamic c = calculator.Add(2, 2.43);

            Assert.AreEqual(4.43, c);
            Assert.AreEqual(4.43, calculator.solution);
        }*/

        /*[TestMethod()]
        public void DivideTest()
        {
            int d = calculator.Divide(70, 35);

            Assert.AreEqual(2, d);
            Assert.AreEqual(2, calculator.solution);
        }*/
    }
}