using LinqToolkit.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToolkit.Lessons._1._QueryExpressions._6._CompositeKeys
{
    class CompositeKeysQueryExpressions
    {
        /// <summary>
        /// this method join creates two anonymous types with the same property
        /// </summary>
        public static IEnumerable<Object> FirstCompositeKeysExample()
        {
            List<Employee2> employees2 = ObjectFactory.GetListOfEmployees2();

            List<Hometown2> hometowns2 = ObjectFactory.GetListOfHomeTowns2();

            IEnumerable<Object> employeeByState = from e in employees2
                                  join h in hometowns2
                                  on new { City = e.City, State = e.State } equals
                                  new { City = h.City, State = h.State }
                                  select new { e.LastName, h.CityCode };

            CommonOperations.PrintEmployee2LastNameAndCityCode(employeeByState);
            return employeeByState;

        }
    }
}
