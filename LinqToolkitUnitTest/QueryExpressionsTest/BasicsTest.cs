using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinqToolkit;
using System.Collections.Generic;

namespace LinqToolkitUnitTest
{
    [TestClass]
    public class BasicsTest
    {
        [TestMethod]
        public void FirstExampleWithoutLinqTest()
        {
            List<int> returnedValue = BasicQueryExpressions.FirstExampleWithLinq();
            List<int> expectedValue = new List<int> { 2, 4, 6, 8, 10 };

            CollectionAssert.AreEqual(expectedValue, returnedValue);
        }

        [TestMethod]
        public void FirstExampleWithLinqTest()
        {
            List<int> returnedValue = BasicQueryExpressions.FirstExampleWithLinq();
            List<int> expectedValue = new List<int> { 2, 4, 6, 8, 10 };

            CollectionAssert.AreEqual(expectedValue, returnedValue);
        }

        [TestMethod]
        public void SecondExampleWithLinqTest()
        {
            List<int> returnedValue = BasicQueryExpressions.SecondExampleWithLinq();
            List<int> expectedValue = new List<int> { 2, 4, 6, 8, 10 };

            CollectionAssert.AreEqual(expectedValue, returnedValue);
        }
    }
}
