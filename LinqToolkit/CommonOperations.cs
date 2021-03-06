﻿using LinqToolkit.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToolkit
{
    public static class CommonOperations
    {
        public static void PrintItemsInCollection(dynamic collection)
        {
            foreach (dynamic i in collection)
            {
                Console.WriteLine(i);
            }
        }


        public static void PrintHomeTownCollection(dynamic hometown)
        {
            foreach (Hometown item in hometown)
            {
                Console.WriteLine(item.City + ", " + item.State);
            }
        }


        public static void PrintEmployeeLastNameAndStateName(dynamic employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.LastName + ", " + employee.StateName);
            }
        }

        public static void PrintEmployees(List<Employee2> employees)
        {
            foreach (var item in employees)
            {
                Console.WriteLine(item.FirstName + ", " + item.LastName+ ", " + item.StateId);
            }
        }

        public static void PrintEmployees2(List<Employee2> employees)
        {
            foreach (var item in employees)
            {
                Console.WriteLine(item.FirstName + ", "+ item.LastName +", "+ item.State +", "+ item.City + ", "+ item.StateId );
            }
        }


        public static void PrintEmployee2LastNameAndCityCode(dynamic employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.LastName + ", " + employee.CityCode);
            }
        }
    }
 }

