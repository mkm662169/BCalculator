﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace operations.Tests
{
    [TestClass()]
    public class CubeTests
    {
        private readonly int a = 5;
        private readonly double b = 5.5;

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