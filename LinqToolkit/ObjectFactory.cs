using LinqToolkit.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToolkit.Lessons._1._QueryExpressions._6._CompositeKeys;

namespace LinqToolkit
{
    public static class ObjectFactory
    {
        public static List<Person> GetListOfPersons()
        {
            return new List<Person>()
            {
                new Person()
                {
                    FirstName = "John",
                    LastName = "Smith",
                    Address1 = "First St",
                    City = "Havertown",
                    State = "PA",
                    Zip = "19084"
                },
                new Person()
                {
                    FirstName = "Jane",
                    LastName = "Doe",
                    Address1 = "Second St",
                    City = "Ewing",
                    State = "NJ",
                    Zip = "08560"
                },
                new Person()
                {
                    FirstName = "Jack",
                    LastName = "Jones",
                    Address1 = "Third St",
                    City = "Ft Washington",
                    State = "PA",
                    Zip = "19034" }
            };
        }

        internal static List<Hometown2> GetListOfHomeTowns2()
        {
            return new List<Hometown2>()
            {
                new Hometown2()
                {
                    City = "Havertown",
                    State = "PA",
                    CityCode = "1234"
                },
                new Hometown2()
                {
                    City = "Ewing",
                    State = "NJ",
                    CityCode = "5678"
                },
                new Hometown2()
                {
                    City = "Fort Washington",
                    State = "PA",
                    CityCode = "9012"
                }
            };
        }

        internal static List<Employee2> GetListOfEmployees2()
        {
            return new List<Employee2>()
            {
                new Employee2()
                {
                    FirstName = "John",
                    LastName = "Smith",
                    City = "Havertown",
                    State = "PA"
                },
                 new Employee2()
                 {
                     FirstName = "Jane",
                     LastName = "Doe",
                     City = "Ewing",
                     State = "NJ"
                 },
                new Employee2()
                {
                    FirstName = "Jack",
                    LastName = "Jones",
                    City = "Fort Washington",
                    State = "PA"
                }
            };
        }

        public static List<Employee> GetListOfEmployees()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    FirstName = "John",
                    LastName = "Smith",
                    StateId = 1
                },
                new Employee()
                {
                    FirstName = "Jane",
                    LastName = "Doe",
                    StateId = 2
                },
                new Employee()
                {
                    FirstName = "Jack",
                    LastName = "Jones",
                    StateId = 1 }
            };
        }


        public static List<State> GetListOfStates()
        {
            return new List<State>()
            {
                new State()
                {
                    StateId = 1, StateName = "PA"
                },
                new State()
                {
                    StateId = 2, StateName = "NJ"
                }
            };
        }
    }
}
