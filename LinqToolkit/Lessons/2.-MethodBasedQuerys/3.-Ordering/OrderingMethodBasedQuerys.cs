using LinqToolkit.models;
using System.Collections.Generic;
using System.Linq;

namespace LinqToolkit.Lessons._2._MethodBasedQuerys.Ordering
{
    class OrderingMethodBasedQuerys
    {
        private static void OrderByThenBy()
        {
            List<Hometown2> hometowns =  ObjectFactory.GetListOfHomeTowns2();
            var orderedHometowns = hometowns.OrderBy(c => c.City).ThenBy(s => s.State);
        }

        private static void OrderByDescendingThenByDescending()
        {
            List<Hometown2> hometowns = ObjectFactory.GetListOfHomeTowns2();
            var orderedDescendingHometowns = hometowns.OrderByDescending(c => c.City).ThenByDescending(s => s.State);
        }
    }
}
