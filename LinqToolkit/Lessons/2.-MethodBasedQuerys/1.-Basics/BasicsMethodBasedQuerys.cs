using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToolkit.Lessons._2._MethodBasedQuerys._1._Basics
{
    class BasicsMethodBasedQuerys
    {
        public static IEnumerable<int> EvenNumbersWithQueryExpressions()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> evenNumbers = from i in myArray
                              where i % 2 == 0
                              select i;

            CommonOperations.PrintItemsInCollection(evenNumbers);

            return evenNumbers;
        }

        public static IEnumerable<int> EvenNumbersWithMethodBasedQuerys()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> evenNumbers = myArray.Where(i => i % 2 == 0);

            CommonOperations.PrintItemsInCollection(evenNumbers);

            return evenNumbers;
        }
    }
}
