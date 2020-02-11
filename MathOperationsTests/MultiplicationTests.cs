using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations.Tests
{
    [TestClass()]
    public class MultiplicationTests
    {
        [TestMethod()]
        public void MultTest()
        {
            var c = Multiplication.Product(3, 2);
            Assert.AreEqual(6, c);
        }
    }
}
