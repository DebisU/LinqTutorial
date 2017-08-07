using LinqToolkit.models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqToolkit.Lessons._2._MethodBasedQuerys.Projection
{
    class ProjectionMethodBaseQuerys
    {
        public static IEnumerable<string> ProjectionSelect()
        {
            List<Person> people = ObjectFactory.GetListOfPeople();
            IEnumerable<string> lastNames = people.Select(p => p.LastName);

            CommonOperations.PrintItemsInCollection(lastNames);

            return lastNames;
        }

        public static IEnumerable<Object> ProjectionSelectWithTwoFields()
        {
            List<Person> people = ObjectFactory.GetListOfPeople();
            IEnumerable<Object> firstNameLastName = people.Select(p => new { p.FirstName, p.LastName });

            CommonOperations.PrintItemsInCollection(firstNameLastName);

            return firstNameLastName;
        }

        public static IEnumerable<Object> ProjectionSelectWithTwoFieldsWithAnonymousType()
        {
            List<Person> people = ObjectFactory.GetListOfPeople();
            IEnumerable<Object> firstNameLastName = people.Select(p => new {First = p.FirstName, Last = p.LastName });

            CommonOperations.PrintItemsInCollection(firstNameLastName);

            return firstNameLastName;
        }

        public static IEnumerable<Object> ProjectionComplexSelectWithAnonymousType()
        {
            List<State> states = ObjectFactory.GetListOfStates();
            List<Employee> employees = ObjectFactory.GetListOfEmployees();

            IEnumerable<Object> employeeByState = employees.SelectMany(e => states.Where(s =>
                e.StateId == s.StateId).Select(s => new { e.LastName, s.StateName }));

            CommonOperations.PrintEmployeeLastNameAndStateName(employeeByState);

            return employeeByState;
        }
    }
}
