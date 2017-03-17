using System;
using System.Linq;


namespace LinqToolkit
{
    class BasicQueryExpressions
    {
        /// <summary>
        /// example without LinQ
        /// this example stores only the even numbers from array into evenNumbers array
        /// </summary>
        public static void FirstExampleWithoutLinq()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] evenNumbers = new int[5];
            int evenIndex = 0;
            foreach (int i in myArray)
            {
                if (i % 2 == 0)
                {
                    evenNumbers[evenIndex] = i; evenIndex++;
                }
            }
            CommonOperations.PrintItemsInCollection(evenNumbers);
        }

        /// <summary>
        /// example with LinQ
        /// this example stores only the even numbers from array into evenNumbers array
        /// </summary>
        public static void FirstExampleWithLinq()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = from i in myArray
                              where i % 2 == 0
                              select i;
            CommonOperations.PrintItemsInCollection(evenNumbers);

        }

        /// <summary>
        /// this example does the same than FirstExampleWithLinq method but
        /// after adding the even numbers to the array it changes the [1]
        /// position of the array to 12
        /// </summary>
        public static void SecondExampleWithLinq()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = 
                from i in myArray
                where i % 2 == 
                0 select i;
            CommonOperations.PrintItemsInCollection(evenNumbers);

            myArray[1] = 12;
            CommonOperations.PrintItemsInCollection(evenNumbers);
        }

        
    }
}
