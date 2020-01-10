using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace operations.Tests
{
    [TestClass()]
    public class CubeTests
    {
        private readonly dynamic a = 5;
        private readonly dynamic b = 5.5;

        [TestMethod()]
        public void CubedTest()
        {
            Assert.AreEqual(125, Cube.Cubed(a));
        }

        [TestMethod()]
        public void CubedDoubleTest()
        {
            Assert.AreEqual(166.375, Cube.Cubed(b));
        }
    }
}