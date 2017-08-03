using LinqToolkit.models;
using System.Collections.Generic;
using System.Linq;

namespace LinqToolkit.Lessons._2._MethodBasedQuerys._5._Joining
{
    class JoiningMethodBasedQuerys
    {
        public static void MethodBasedJoin()
        {
            List<State> states = ObjectFactory.GetListOfStates();
            List<Employee> employees = ObjectFactory.GetListOfEmployees();

            var employeeByState = employees.Join(states,
                                        e => e.StateId,
                                        s => s.StateId,
                                        (e, s) => new { e.LastName, s.StateName });
        }

        public static void MethodBasedOuterJoin()
        {
            List<State> states = ObjectFactory.GetListOfStates();
            List<Employee> employees = ObjectFactory.GetListOfEmployees();

            var employeeByState = employees.GroupJoin(states,
                                        e => e.StateId,
                                        s => s.StateId,
                                        (e, employeeGroup) => employeeGroup.Select(s => new
                                            {
                                                LastName = e.LastName,
                                                StateName = s.StateName
                                            }).DefaultIfEmpty(new
                                                {
                                                    LastName = e.LastName,
                                                    StateName = ""
                                                })).SelectMany(employeeGroup => employeeGroup);
        }

        public static void MethodBasedOuterJoinInto()
        {
            List<State> states = ObjectFactory.GetListOfStates();
            List<Employee> employees = ObjectFactory.GetListOfEmployees();

            var employeeByState = from e in employees
                                  join s in states
                                  on e.StateId equals s.StateId into employeeGroup  //<<<<< creating var employeeGroup and filling
                                  from item in employeeGroup.DefaultIfEmpty(new State
                                  {
                                      StateId = 0,
                                      StateName = ""
                                  })
                                  select new { e.LastName, item.StateName };
        }

        public static void MethodBasedGroupJoin()
        {
            List<State> states = ObjectFactory.GetListOfStates();
            List<Employee> employees = ObjectFactory.GetListOfEmployees();

            var employeeByState = employees.GroupJoin(states,
                                    e => e.StateId,
                                    s => s.StateId,
                                    (e, employeeGroup) => employeeGroup.Select(s => new
                                        {
                                            LastName = e.LastName,
                                            StateName = s.StateName
                                        }).DefaultIfEmpty(new
                                            {
                                                LastName = e.LastName,
                                                StateName = ""
                                            })).SelectMany(e => e);
        }

        public static void MethodBasedCompositeKeys()
        {
            List<State> states = ObjectFactory.GetListOfStates();
            List<Hometown2> hometowns = ObjectFactory.GetListOfHomeTowns2();
            List<Employee2> employees = ObjectFactory.GetListOfEmployees2();

            var employeeByState = employees.Join(hometowns,
                                    e => new { City = e.City, State = e.State },
                                    h => new { City = h.City, State = h.State },
                                        (e, h) => new { e.LastName, h.CityCode });
        }


    }
}
