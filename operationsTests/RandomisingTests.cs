using Microsoft.VisualStudio.TestTools.UnitTesting;
using operations;
namespace operations.Tests
{
    [TestClass()]
    public class RandomisingTests
    {
        private readonly int min = 10;
        private readonly int max = 30;
        private readonly Randomising random =  new Randomising(5);
        [TestMethod()]
        public void RandomiseTest()
        {
            //Assert.IsTrue();
            Assert.AreEqual(random.GenerateRandomNumber(min, max), random.GenerateRandomNumber(min, max));
        }
    }
}