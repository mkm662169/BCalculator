using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace operations.Tests
{
    [TestClass()]
    public class RootTests
    {
        private readonly dynamic a = 100;
        private readonly dynamic b = 10.1;
        [TestMethod()]
        public void SqrtTest()
        {
            Assert.AreEqual(10, Root.Sqrt(a));
            Assert.AreEqual(3.1780497164141406804582045589355, Root.Sqrt(b));
        }
    }
}