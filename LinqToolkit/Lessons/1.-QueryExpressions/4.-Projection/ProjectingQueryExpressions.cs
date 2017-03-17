using LinqToolkit.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToolkit.Lessons._4._Projection
{
    public static class ProjectingQueryExpressions
    {
        /// <summary>
        /// this method generate a list<string> with the persons.LastName propery
        /// </summary>
        public static void FirstProjectionExample()
        {
            List<Person> people = ObjectFactory.GetListOfPersons();
            var lastNames = from p in people
                            select p.LastName;

            CommonOperations.PrintItemsInCollection(lastNames);
        }

        /// <summary>
        /// this method do tha same than FirstProjectionExample but with FirstName and LastName
        /// </summary>
        public static void SecondProjectionExample()
        {
            List<Person> people = ObjectFactory.GetListOfPersons();
            var firstAndLastNames = from p in people
                            select new { p.FirstName, p.LastName };

            foreach (var item in people)
            {
                Console.WriteLine(item.FirstName + ", " + item.LastName);
            }
        }

        /// <summary>
        /// this method do tha same than SecondProjectionExample but with FirstName and LastName with alias
        /// </summary>
        public static void ThirdProjectionExample()
        {
            List<Person> people = ObjectFactory.GetListOfPersons();
            var firstAndLastNames = from p in people
                                    select new {First = p.FirstName,Last = p.LastName };

            foreach (var item in firstAndLastNames)
            {
                Console.WriteLine(item.First + ", " + item.Last);
            }
        }
    }
}
