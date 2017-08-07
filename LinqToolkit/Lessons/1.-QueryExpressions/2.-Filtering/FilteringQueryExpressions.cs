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
        public static List<int> FirstFilteringExample()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNumbersGT5 = (from i in myArray
                              where i % 2 == 0 && i > 5
                              select i).ToList();
            CommonOperations.PrintItemsInCollection(evenNumbersGT5);
            return evenNumbersGT5;
        }

        /// <summary>
        /// this example adds the even numbers greather than 5 to the evenNumbers array
        /// with two where statements.
        /// the result is equivalent to FirstFilteringExample method
        /// </summary>
        public static List<int> SecondFilteringExample()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNumbersGT5 = (from i in myArray
                              where i % 2 == 0 
                              where i > 5
                              select i).ToList();
            CommonOperations.PrintItemsInCollection(evenNumbersGT5);
            return evenNumbersGT5;
        }

        /// <summary>
        /// this example do the same than SecondFilteringExample method but
        /// calling a function in the where clausule
        /// </summary>
        public static List<int> ThirdFilteringExample()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNumbersGT5 = (from i in myArray
                              where IsEvenAndGT5(i)
                              select i).ToList();
            CommonOperations.PrintItemsInCollection(evenNumbersGT5);
            return evenNumbersGT5;
        }

        private static bool IsEvenAndGT5(int toEvaluate)
        {
            return (toEvaluate % 2 == 0 && toEvaluate > 5);
        }

    }
}
