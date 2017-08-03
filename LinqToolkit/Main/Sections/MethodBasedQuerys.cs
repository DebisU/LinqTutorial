using LinqToolkit.Lessons._2._MethodBasedQuerys._1._Basics;
using LinqToolkit.Lessons._2._MethodBasedQuerys._5._Joining;
using LinqToolkit.Lessons._2._MethodBasedQuerys._6._Grouping;
using LinqToolkit.Lessons._2._MethodBasedQuerys._7._AgregateFunctions;
using LinqToolkit.Lessons._2._MethodBasedQuerys.FIltering;
using LinqToolkit.Lessons._2._MethodBasedQuerys.Ordering;
using LinqToolkit.Lessons._2._MethodBasedQuerys.Projection;
using System;

namespace LinqToolkit.Main.Sections
{
    class MethodBasedQuerys
    {
        public static void RunMethodBasedQuerys()
        {
            Basics();
            Filtering();
            Ordering();
            Projection();
            Joining();
            Grouping();
            AgregateFunctions();
        }

        private static void Basics()
        {
            Print();
            Print("Basics 1:");
            BasicsMethodBasedQuerys.EvenNumbersWithQueryExpressions();
            Print();
            Print("Basics 2:");
            BasicsMethodBasedQuerys.EvenNumbersWithMethodBasedQuerys();
        }

        private static void Filtering()
        {
            Print();
            Print("Filtering 1:");
            FilteringMethodBasedQuerys.FilterEvenNumbersAndGT5Way1();
            Print();
            Print("Filtering 2:");
            FilteringMethodBasedQuerys.FilterEvenNumbersAndGT5Way2();
            Print();
            Print("Filtering 3:");
            FilteringMethodBasedQuerys.FilterEvenNumbersCallingMethod();
        }

        private static void Ordering()
        {
            Print();
            Print("Ordering 1:");
            OrderingMethodBasedQuerys.OrderByThenBy();
            Print();
            Print("Ordering 2:");
            OrderingMethodBasedQuerys.OrderByDescendingThenByDescending();
        }

        private static void Projection()
        {
            Print();
            Print("Projection 1:");
            ProjectionMethodBaseQuerys.ProjectionSelect();
            Print();
            Print("Projection 2:");
            ProjectionMethodBaseQuerys.ProjectionSelectWithTwoFields();
            Print();
            Print("Projection 3:");
            ProjectionMethodBaseQuerys.ProjectionSelectWithTwoFieldsWithAnonymousType();
            Print();
            Print("Projection 4:");
            ProjectionMethodBaseQuerys.ProjectionComplexSelectWithAnonymousType();
        }

        private static void Joining()
        {
            Print();
            Print("Joining 1:");
            JoiningMethodBasedQuerys.MethodBasedJoin();
            Print();
            Print("Joining 2:");
            JoiningMethodBasedQuerys.MethodBasedOuterJoin();
            Print();
            Print("Joining 3:");
            JoiningMethodBasedQuerys.MethodBasedOuterJoinInto();
            Print();
            Print("Joining 4:");
            JoiningMethodBasedQuerys.MethodBasedGroupJoin();
            Print();
            Print("Joining 5:");
            JoiningMethodBasedQuerys.MethodBasedCompositeKeys();
        }

        private static void Grouping()
        {
            Print();
            Print("Grouping");
            GroupingMethodBasedQuerys.GroupingBy();
            Print();
            Print("Grouping");
            GroupingMethodBasedQuerys.GroupingBy2Fields();
        }

        private static void AgregateFunctions()
        {
            Print();
            Print("AgregateFunctions count:");
            AgreagateFunctionsMethodBaseQuerys.AgregateCount();
            Print();
            Print("AgregateFunctions average:");
            AgreagateFunctionsMethodBaseQuerys.AgreagateAverage();
            Print();
            Print("AgregateFunctions sum:");
            AgreagateFunctionsMethodBaseQuerys.AgreagateSum();
            Print();
            Print("AgregateFunctions min:");
            AgreagateFunctionsMethodBaseQuerys.AgreagateMin();
            Print();
            Print("AgregateFunctions max:");
            AgreagateFunctionsMethodBaseQuerys.AgregateMax();
            Print();
            Print("AgregateFunctions first:");
            AgreagateFunctionsMethodBaseQuerys.AgregateFirst();
            Print();
            Print("AgregateFunctions last:");
            AgreagateFunctionsMethodBaseQuerys.AgregateLast();
            Print();
            Print("AgregateFunctions concatenation:");
            AgreagateFunctionsMethodBaseQuerys.AgregateConcatenation();
            Print();
            Print("AgregateFunctions skip:");
            AgreagateFunctionsMethodBaseQuerys.AgregateSkip();
            Print();
            Print("AgregateFunctions take:");
            AgreagateFunctionsMethodBaseQuerys.AgregateTake();
            Print();
            Print("AgregateFunctions skip & take:");
            AgreagateFunctionsMethodBaseQuerys.AgregateSkipTakeMix();
            Print();
            Print("AgregateFunctions distinct:");
            AgreagateFunctionsMethodBaseQuerys.AgregateDistinct();
        }

        private static void Print(string str = "")
        {
            Console.WriteLine(str);
        }
    }
}
