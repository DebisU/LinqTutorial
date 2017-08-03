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
        public static void GroupingBy()
        {
            List<Employee2> employees = ObjectFactory.GetListOfEmployees2();

            var employeesByState = employees.OrderBy(s => s.State);
        }

        public static void GroupingBy2Fields()
        {
            List<Employee2> employees = ObjectFactory.GetListOfEmployees2();

            var employeesByStateAndCity = employees.OrderBy(e => new { e.State, e.City });
        }
    }
}
