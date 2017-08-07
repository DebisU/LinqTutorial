using LinqToolkit;
using LinqToolkit.Lessons._4._Projection;
using LinqToolkit.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LinqToolkitUnitTest.QueryExpressionsTest
{
    [TestClass]
    public class ProjectingTest
    {
        [TestMethod]
        public void FirstProjectingExampleTest()
        {
            List<string> returnedValue = ProjectingQueryExpressions.FirstProjectionExample();
            List<string> expectedValue = RetrieveFirstExampleExpectedValue();

            CollectionAssert.AreEqual(expectedValue, returnedValue);
        }

        [TestMethod]
        public void SecondProjectingExampleTest()
        {
            //List<int> returnedValue = ProjectingQueryExpressions.SecondProjectionExample();
            //List<int> expectedValue = new List<int> { 10, 8, 6, 4, 2 };

            //CollectionAssert.AreEqual(expectedValue.ToArray(), returnedValue.ToArray());
        }

        [TestMethod]
        public void ThirProjectingExampleTest()
        {
            //List<int> returnedValue = ProjectingQueryExpressions.ThirdProjectionExample();
            //List<int> expectedValue = new List<int> { 10, 8, 6, 4, 2 };

            //CollectionAssert.AreEqual(expectedValue.ToArray(), returnedValue.ToArray());
        }


        private List<string> RetrieveFirstExampleExpectedValue()
        {
            List<Person> people = ObjectFactory.GetListOfPeople();
            List<string> names = new List<string>();
            foreach (var item in people)
            {
                names.Add(item.LastName);
            }
            return names;
        }
    }
}
