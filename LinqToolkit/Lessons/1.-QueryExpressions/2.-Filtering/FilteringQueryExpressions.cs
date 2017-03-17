using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToolkit
{
    public class FilteringQueryExpressions
    {
        /// <summary>
        /// this example adds the even numbers greather than 5 to the evenNumbers array
        /// with a where and &&.
        /// </summary>
        public static void FirstFilteringExample()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = from i in myArray
                              where i % 2 == 0 && i > 5
                              select i;
            CommonOperations.PrintItemsInCollection(evenNumbers);
        }

        /// <summary>
        /// this example adds the even numbers greather than 5 to the evenNumbers array
        /// with two where statements.
        /// the result is equivalent to FirstFilteringExample method
        /// </summary>
        public static void SecondFilteringExample()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = from i in myArray
                              where i % 2 == 0 
                              where i > 5
                              select i;
            CommonOperations.PrintItemsInCollection(evenNumbers);
        }

        /// <summary>
        /// this example do the samen than SecondFilteringExample method but
        /// calling a function in the where clausule
        /// </summary>
        public static void ThirdFilteringExample()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = from i in myArray
                              where IsEvenAndGT5(i)
                              select i;
            CommonOperations.PrintItemsInCollection(evenNumbers);
        }

        private static bool IsEvenAndGT5(int toEvaluate)
        {
            return (toEvaluate % 2 == 0 && toEvaluate > 5);
        }

    }
}
