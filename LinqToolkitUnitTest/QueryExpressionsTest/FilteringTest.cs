using LinqToolkit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LinqToolkitUnitTest.QueryExpressionsTest
{
    [TestClass]
    public class FilteringTest
    {
        [TestMethod]
        public void FirstFilteringExampleTest()
        {
            List<int> returnedValue = FilteringQueryExpressions.FirstFilteringExample();
            List<int> expectedValue = new List<int> { 6, 8, 10 };

            CollectionAssert.AreEqual(expectedValue, returnedValue);
        }

        [TestMethod]
        public void SecondFilteringExampleTest()
        {
            List<int> returnedValue = FilteringQueryExpressions.SecondFilteringExample();
            List<int> expectedValue = new List<int> { 6, 8, 10 };

            CollectionAssert.AreEqual(expectedValue, returnedValue);
        }

        [TestMethod]
        public void ThirdFilteringExampleTest()
        {
            List<int> returnedValue = FilteringQueryExpressions.ThirdFilteringExample();
            List<int> expectedValue = new List<int> { 6, 8, 10 };

            CollectionAssert.AreEqual(expectedValue, returnedValue);
        }


    }

}
