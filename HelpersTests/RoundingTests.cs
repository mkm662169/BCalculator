﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Helpers.Tests
{
    [TestClass()]
    public class RoundingTests
    {
        private readonly double num = 10.25840000000005;
        [TestMethod()]
        public void DecimalLengthTest()
        {
            Assert.AreEqual(10.26, Rounding.RoundToTwo(num));
        }
    }
}