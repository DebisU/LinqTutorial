using LinqToolkit.models;
using System.Collections.Generic;
using System.Linq;

namespace LinqToolkit
{
    public static class OrderingQueryExpressions
    {
        /// <summary>
        /// this method pick the even numbers and order them descending
        /// </summary>
        public static List<int> FirstOrderingExample()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNumbers = (from i in myArray
                              where i % 2 == 0
                              orderby i descending
                              select i).ToList();
            CommonOperations.PrintItemsInCollection(evenNumbers);
            return evenNumbers;
        }

        /// <summary>
        /// this method order first by hometown state and then by city both descending
        /// the result:
        /// Ewing, NJ
        /// Trenton, NJ
        /// Fort Washington, PA
        /// PAHavertown, PA
        /// Philadelphia, PA
        /// </summary>
        public static List<Hometown> SecondOrderingExampleOrderingHometowns()
        {
            List<Hometown> hometowns = new List<Hometown>()
            {
                new Hometown() { City = "Philadelphia", State = "PA" },
                new Hometown() { City = "Ewing", State = "NJ" },
                new Hometown() { City = "Havertown", State = "PA" },
                new Hometown() { City = "Fort Washington", State = "PA" },
                new Hometown() { City = "Trenton", State = "NJ" }
            };

            List<Hometown> orderedHometowns = (from h in hometowns
                                   orderby h.State ascending, h.City ascending
                                   select h).ToList();
            CommonOperations.PrintHomeTownCollection(orderedHometowns);
            return orderedHometowns;
        }
    }
}
