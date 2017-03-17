using LinqToolkit.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToolkit.Lessons._5._Joining
{
    public static class JoiningQueryExpressions
    {
        /// <summary>
        /// this example joins employees with states with the relation
        /// between empployee.stateId and state.stateId
        /// </summary>
        public static void FirstJoiningExample()
        {
            List<Employee> employees = ObjectFactory.GetListOfEmployees();

            List<State> states = ObjectFactory.GetListOfStates();

            var employeeByState = from e in employees
                                  join s in states
                                  on e.StateId equals s.StateId
                                  select new { e.LastName, s.StateName };

            CommonOperations.PrintEmployeeLastNameAndStateName(employeeByState);
        }


        /// <summary>
        /// this ejample makes and outer join
        /// </summary>
        public static void SecondJoiningExample()
        {
            List<Employee> employees = ObjectFactory.GetListOfEmployees();

            List<State> states = ObjectFactory.GetListOfStates();

            var employeeByState = from e in employees
                                  join s in states on e.StateId equals s.StateId into employeeGroup
                                  from item in employeeGroup.DefaultIfEmpty(new State
                                                                            {
                                                                              StateId = 0,
                                                                              StateName = ""
                                                                            })
                                  select new { e.LastName, item.StateName };

            CommonOperations.PrintEmployeeLastNameAndStateName(employeeByState);
        }
    }
}
