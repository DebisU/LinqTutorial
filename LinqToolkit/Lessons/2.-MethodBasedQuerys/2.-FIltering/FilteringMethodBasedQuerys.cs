using System.Collections.Generic;
using System.Linq;

namespace LinqToolkit.Lessons._2._MethodBasedQuerys.FIltering
{
    class FilteringMethodBasedQuerys
    {
        public static IEnumerable<int> FilterEvenNumbersAndGT5Way1()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> filteredArray = myArray.Where(i => i % 2 == 0 && i > 5);

            CommonOperations.PrintItemsInCollection(filteredArray);

            return filteredArray;
        }

        public static IEnumerable<int> FilterEvenNumbersAndGT5Way2()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> filteredArray = myArray.Where(i => i % 2 == 0)
                                                    .Where(i => i > 5);

            CommonOperations.PrintItemsInCollection(filteredArray);


            return filteredArray;
        }

        public static IEnumerable<int> FilterEvenNumbersCallingMethod()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> filteredArray = myArray.Where( i => IsEvenNumber(i) );

            CommonOperations.PrintItemsInCollection(filteredArray);

            return filteredArray;
        }


        private static bool IsEvenNumber(int number)
        {
            return number % 2 == 0;
        }
    }
}
