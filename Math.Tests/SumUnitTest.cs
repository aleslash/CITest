using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math;

namespace Math.Tests
{
    [TestClass]
    public class SumUnitTest
    {
        [TestMethod]
        public void OKAddTwoNumbers()
        {
            Assert.AreEqual(Sum.AddTwoNumbers(10, 11), 21); 
        }
    }
}
