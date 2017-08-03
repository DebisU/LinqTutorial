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

            IEnumerable<Employee2> employeesByState = employees.OrderBy(s => s.State);

            return employeesByState;
        }

        public static IEnumerable<Employee2> GroupingBy2Fields()
        {
            List<Employee2> employees = ObjectFactory.GetListOfEmployees2();

            IEnumerable<Employee2> employeesByStateAndCity = employees.OrderBy(e => new { e.State, e.City });

            return employeesByStateAndCity;
        }
    }
}
