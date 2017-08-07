using LinqToolkit;
using LinqToolkit.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToolkitUnitTest.QueryExpressionsTest
{
    [TestClass]
    public class OrderingTest
    {
        [TestMethod]
        public void FirstOrderingExampleTest()
        {
            List<int> returnedValue = OrderingQueryExpressions.FirstOrderingExample();
            List<int> expectedValue = new List<int> {10,8,6,4,2};

            CollectionAssert.AreEqual(expectedValue, returnedValue);
        }

        [TestMethod]
        public void SecondOrderingExampleTest()
        {
            List<Hometown> returnedValue = OrderingQueryExpressions.SecondOrderingExampleOrderingHometowns();
            List<Hometown> expectedValue = new List<Hometown>()
            {
                new Hometown() { City = "Ewing", State = "NJ" },
                new Hometown() { City = "Trenton", State = "NJ" },
                new Hometown() { City = "Fort Washington", State = "PA" },
                new Hometown() { City = "Havertown", State = "PA" },
                new Hometown() { City = "Philadelphia", State = "PA" }
            };

            CollectionAssert.AreEqual(expectedValue, returnedValue);
        }
    }
}
