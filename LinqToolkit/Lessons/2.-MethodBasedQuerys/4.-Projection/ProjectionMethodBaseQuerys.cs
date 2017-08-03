using LinqToolkit.models;
using System.Collections.Generic;
using System.Linq;

namespace LinqToolkit.Lessons._2._MethodBasedQuerys.Projection
{
    class ProjectionMethodBaseQuerys
    {
        public static void ProjectionSelect()
        {
            List<Person> people = ObjectFactory.GetListOfPeople();
            var lastNames = people.Select(p => p.LastName);
        }

        public static void ProjectionSelectWithTwoFields()
        {
            List<Person> people = ObjectFactory.GetListOfPeople();
            var firstNameLastName = people.Select(p => new { p.FirstName, p.LastName });
        }

        public static void ProjectionSelectWithTwoFieldsWithAnonymousType()
        {
            List<Person> people = ObjectFactory.GetListOfPeople();
            var firstNameLastName = people.Select(p => new {First = p.FirstName, Last = p.LastName });
        }

        public static void ProjectionComplexSelectWithAnonymousType()
        {
            List<State> states = ObjectFactory.GetListOfStates();
            List<Employee> employees = ObjectFactory.GetListOfEmployees();

            var employeeByState = employees.SelectMany(e => states.Where(s =>
                e.StateId == s.StateId).Select(s => new { e.LastName, s.StateName }));
        }
    }
}
