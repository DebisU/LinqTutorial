using LinqToolkit.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToolkit.Lessons._2._MethodBasedQuerys._6._Grouping
{
    class GroupingMethodBasedQuerys
    {
        public static IEnumerable<Employee2> GroupingBy()
        {
            List<Employee2> employees = ObjectFactory.GetListOfEmployees2();

            List<Employee2> employeesByState = employees.OrderBy(s => s.State).ToList();

            CommonOperations.PrintEmployees2(employeesByState);

            return employeesByState;
        }

        public static IEnumerable<Employee2> GroupingBy2Fields()
        {
            List<Employee2> employees = ObjectFactory.GetListOfEmployees2();

            var employeesByStateAndCity = employees.OrderBy(e => new { e.State, e.City });

            //CommonOperations.PrintEmployees2(employeesByStateAndCity); implement iComparable to do this operation

            return employeesByStateAndCity;
        }
    }
}
