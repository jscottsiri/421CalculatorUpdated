using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        [TestMethod()]
        public void DiviTest()
        {
            var c = Division.Quotient(6, 2);
            Assert.AreEqual(3, c);
        }
    }
}