using LinqToolkit.models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqToolkit.Lessons._2._MethodBasedQuerys._7._AgregateFunctions
{
    class AgreagateFunctionsMethodBaseQuerys
    {
        public static int AgregateCount()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int count = myArray.Where(e => e % 2 == 0).Count();
            return count;
        }

        public static Double AgreagateAverage()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Double average = myArray.Where(e => e % 2 == 0).Average();
            return average;
        }

        public static int AgreagateSum()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = myArray.Where(e => e % 2 == 0).Sum();
            return sum;
        }

        public static int AgreagateMin()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int min = myArray.Where(e => e % 2 == 0).Min();
            return min;
        }

        public static int AgregateMax()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int max = myArray.Where(e => e % 2 == 0).Max();
            return max;
        }

        public static int AgregateFirst()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int first = myArray.Where(e => e % 2 == 0).First(); //as well FirstOrDefault() if not sure if any
            return first;
        }

        public static int AgregateLast()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int last = myArray.Where(e => e % 2 == 0).Last(); //as well LastOrDefault() if not sure if any
            return last;
        }

        public static List<Employee2> AgregateConcatenation()
        {
            List<Employee2> employees = ObjectFactory.GetListOfEmployees2();
            List<Employee2> employees2 = new List<Employee2>()
            {
                new Employee2()
                {
                    FirstName = "Debisu",
                    LastName = "Uchiha",
                    City = "Konoha",
                    State = "",
                    StateId = 1
                }
            };

            List<Employee2> mixedLists = employees.Concat(employees2).ToList();

            return mixedLists;
        }

        public static void AgregateMixedObjectConcatenation()
        {
            List<Employee2> employees = ObjectFactory.GetListOfEmployees2();
            List<Person> people = ObjectFactory.GetListOfPeople();

            var combinedEmployees = employees.Select(e => new {
                Name = e.LastName}).Concat(people.Select(p => new { Name = p.LastName }));
        }

        public static List<int> AgregateSkip()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> allNumbersExceptTheFirstOne = myArray.Skip(1).ToList(); //this forces to skip the first value and take the rest
            return allNumbersExceptTheFirstOne;
        }

        public static List<int> AgregateTake()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> top2Numbers = myArray.Take(2).ToList(); //this forces to take the first 2 values (top ones)
            return top2Numbers;
        }

        public static List<int> AgregateSkipTakeMix()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> numbersSkippingFirstAndTaking2 = myArray.Skip(1).Take(2).ToList(); //this will skip the first number and take the following 2 numbers
            return numbersSkippingFirstAndTaking2;
        }

        public static List<int> AgregateDistinct()
        {
            int[] myArray = new int[19] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 1, 1, 1, 1, 1, 1, 1, 1};
            List<int> myArrayWithoutDuplicates = myArray.Distinct().ToList(); //this will delete duplicates
            return myArrayWithoutDuplicates;
        }
    }
}
