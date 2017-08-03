using LinqToolkit.models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqToolkit.Lessons._2._MethodBasedQuerys._5._Joining
{
    class JoiningMethodBasedQuerys
    {
        public static IEnumerable<Object> MethodBasedJoin()
        {
            List<State> states = ObjectFactory.GetListOfStates();
            List<Employee> employees = ObjectFactory.GetListOfEmployees();

            IEnumerable<Object> employeeByState = employees.Join(states,
                                        e => e.StateId,
                                        s => s.StateId,
                                        (e, s) => new { e.LastName, s.StateName });
            return employeeByState;
        }

        public static IEnumerable<Object> MethodBasedOuterJoin()
        {
            List<State> states = ObjectFactory.GetListOfStates();
            List<Employee> employees = ObjectFactory.GetListOfEmployees();

            IEnumerable<Object> employeeByState = employees.GroupJoin(states,
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
            return employeeByState;
        }

        public static IEnumerable<Object> MethodBasedOuterJoinInto()
        {
            List<State> states = ObjectFactory.GetListOfStates();
            List<Employee> employees = ObjectFactory.GetListOfEmployees();

            IEnumerable<Object> employeeByState = from e in employees
                                  join s in states
                                  on e.StateId equals s.StateId into employeeGroup  //<<<<< creating var employeeGroup and filling
                                  from item in employeeGroup.DefaultIfEmpty(new State
                                  {
                                      StateId = 0,
                                      StateName = ""
                                  })
                                  select new { e.LastName, item.StateName };
            return employeeByState;
        }

        public static IEnumerable<Object> MethodBasedGroupJoin()
        {
            List<State> states = ObjectFactory.GetListOfStates();
            List<Employee> employees = ObjectFactory.GetListOfEmployees();

            IEnumerable<Object> employeeByState = employees.GroupJoin(states,
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
            return employeeByState;
        }

        public static IEnumerable<Object> MethodBasedCompositeKeys()
        {
            List<State> states = ObjectFactory.GetListOfStates();
            List<Hometown2> hometowns = ObjectFactory.GetListOfHomeTowns2();
            List<Employee2> employees = ObjectFactory.GetListOfEmployees2();

            IEnumerable<Object> employeeByState = employees.Join(hometowns,
                                    e => new { City = e.City, State = e.State },
                                    h => new { City = h.City, State = h.State },
                                        (e, h) => new { e.LastName, h.CityCode });

            return employeeByState;
        }


    }
}
