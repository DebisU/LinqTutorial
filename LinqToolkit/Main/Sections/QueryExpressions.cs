using LinqToolkit.Lessons._1._QueryExpressions._6._CompositeKeys;
using LinqToolkit.Lessons._1._QueryExpressions._7._Grouping;
using LinqToolkit.Lessons._4._Projection;
using LinqToolkit.Lessons._5._Joining;
using System;

namespace LinqToolkit.Main.Sections
{
    class QueryExpressions
    {
        public static void RunQueryExpressions()
        {
            Basics();
            Filtering();
            Ordering();     
            Projection();        
            Joining();
            CompositeKeys();
            Grouping();
        }

        private static void Basics()
        {
            Print();
            Print("Bascis 1: ");
            BasicQueryExpressions.FirstExampleWithoutLinq();
            Print();
            Print("Bascis 2: ");
            BasicQueryExpressions.FirstExampleWithoutLinq();
            Print();
            Print("Bascis 3: ");
            BasicQueryExpressions.SecondExampleWithLinq();
        }

        private static void Filtering()
        {
            Print();
            Print("Filtering 1: ");
            FilteringQueryExpressions.FirstFilteringExample();
            Print();
            Print("Filtering 2: ");
            FilteringQueryExpressions.SecondFilteringExample();
            Print();
            Print("Filtering 3: ");
            FilteringQueryExpressions.ThirdFilteringExample();
        }

        private static void Ordering()
        {
            Print();
            Print("Ordering 1: ");
            OrderingQueryExpressions.FirstOrderingExample();
            Print();
            Print("Ordering 2: ");
            OrderingQueryExpressions.SecondOrderingExampleOrderingHometowns();
        }

        private static void Projection()
        {
            Print();
            Print("Projection 1: ");
            ProjectingQueryExpressions.FirstProjectionExample();
            Print();
            Print("Projection 2: ");
            ProjectingQueryExpressions.SecondProjectionExample();
            Print();
            Print("Projection 3: ");
            ProjectingQueryExpressions.ThirdProjectionExample();
        }

        private static void Joining()
        {
            Print();
            Print("Joining 1: ");
            JoiningQueryExpressions.FirstJoiningExample();
            Print();
            Print("Joining 2: ");
            JoiningQueryExpressions.SecondJoiningExample();
        }

        private static void CompositeKeys()
        {
            Print();
            Print("Composite keys 1: ");
            CompositeKeysQueryExpressions.FirstCompositeKeysExample();
        }

        private static void Grouping()
        {
            Print();
            Print("Grouping 1: ");
            GroupingQueryExpressions.FirstGroupingExample();
            Print();
            Print("Grouping 2: ");
            GroupingQueryExpressions.SecondGroupExample();
            Print();
            Print("Grouping 3: ");
            GroupingQueryExpressions.ThirdGroupExample();
        }

        private static void Print(string str = "")
        {
            Console.WriteLine(str);
        }
    }
}
