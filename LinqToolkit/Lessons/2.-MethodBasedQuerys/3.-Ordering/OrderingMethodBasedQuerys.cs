using LinqToolkit.models;
using System.Collections.Generic;
using System.Linq;

namespace LinqToolkit.Lessons._2._MethodBasedQuerys.Ordering
{
    class OrderingMethodBasedQuerys
    {
        public static IEnumerable<Hometown2> OrderByThenBy()
        {
            List<Hometown2> hometowns =  ObjectFactory.GetListOfHomeTowns2();
            IEnumerable<Hometown2> orderedHometowns = hometowns.OrderBy(c => c.City).ThenBy(s => s.State);
            return orderedHometowns;
        }

        public static IEnumerable<Hometown2> OrderByDescendingThenByDescending()
        {
            List<Hometown2> hometowns = ObjectFactory.GetListOfHomeTowns2();
            IEnumerable<Hometown2> orderedDescendingHometowns = hometowns.OrderByDescending(c => c.City).ThenByDescending(s => s.State);
            return orderedDescendingHometowns;
        }
    }
}
