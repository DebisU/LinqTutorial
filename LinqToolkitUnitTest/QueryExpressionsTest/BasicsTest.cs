using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinqToolkit;
using System.Collections.Generic;

namespace LinqToolkitUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstExampleWithoutLinqTest()
        {
            IEnumerable<int> returnedValue = BasicQueryExpressions.FirstExampleWithLinq();
            int[] expectedValue = new int[5] { 2, 4, 6, 8, 10 };

            Assert.AreEqual(expectedValue, returnedValue);
        }
    }
}
