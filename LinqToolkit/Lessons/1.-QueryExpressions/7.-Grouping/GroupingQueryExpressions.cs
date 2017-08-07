using LinqToolkit.models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqToolkit.Lessons._1._QueryExpressions._7._Grouping
{
    public class GroupingQueryExpressions
    {
        /// <summary>
        /// the following code creates a List of Employee objects and then executes a query to group them by State.
        /// The count of the employees by state can then be written to the Output window:
        /// </summary>
        public static void FirstGroupingExample()
        {
            List<Employee2> employees2 = ObjectFactory.GetListOfEmployees2();

            var employeesByState = from e in employees2
                                   group e by e.State;
            foreach (var employeeGroup in employeesByState)
            {
                Console.WriteLine(employeeGroup.Key + ": " + employeeGroup.Count());

                foreach (var employee in employeeGroup)
                {
                    Console.WriteLine(employee.LastName + ", " + employee.State);
                }
            }
        }


        /// <summary>
        /// The following example groups even and odd number and then prints the count and sum of each group to the Output window:
        /// </summary>
        public static void SecondGroupExample()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var groupedNumbers = from i in myArray
                                 group i by (EvenOrOddNumber(i)).ToList();
            foreach (var groupNumber in groupedNumbers)
            {
                Console.WriteLine(groupNumber.ToString());
                CommonOperations.PrintItemsInCollection(groupedNumbers);
            }
        }

        /// <summary>
        ///  select the key and the sum of even or odd numbers in the query.
        /// </summary>
        public static void ThirdGroupExample()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var groupedNumbers = from i in myArray
                                 group i by (EvenOrOddNumber(i)) into g
                                 select new
                                 {
                                     Key = g.Key, SumOfNumbers = g.Sum()
                                 };
            foreach (var groupNumber in groupedNumbers)
            {
                Console.WriteLine(groupNumber.Key + ": " + groupNumber.SumOfNumbers);
            }
        }

        private static string EvenOrOddNumber(int number)
        {
            return (number % 2 == 0 ? "Even" : "Odd");
        }
    }
}
