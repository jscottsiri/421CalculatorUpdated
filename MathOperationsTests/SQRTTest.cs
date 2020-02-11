using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations.Tests
{
    [TestClass()]
    public class SQRTTests
    {
        [TestMethod()]
        public void SQRTTest()
        {
            var c = SQRT.End(9);
            Assert.AreEqual(3);
        }
    }
}
