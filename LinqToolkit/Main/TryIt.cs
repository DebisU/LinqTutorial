using LinqToolkit.Lessons._1._QueryExpressions._6._CompositeKeys;
using LinqToolkit.Lessons._1._QueryExpressions._7._Grouping;
using LinqToolkit.Lessons._3._XML;
using LinqToolkit.Lessons._4._Projection;
using LinqToolkit.Lessons._5._Joining;
using LinqToolkit.Main.Sections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToolkit
{
    class TryIt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("QUERY EXPRESSIONS");
            Console.WriteLine("---------------------------------------");
            RunQueryExpressions();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("METHOD BASED QUERYS");
            Console.WriteLine("---------------------------------------");
            RunMethodBasedQuerys();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("LINQ TO XML");
            Console.WriteLine("---------------------------------------");
            RunLinqToXml();
        }

        private static void RunQueryExpressions()
        {
            QueryExpressions.RunQueryExpressions();
            Console.WriteLine("press any key to continue.");
            Console.ReadLine();
        }

        private static void RunMethodBasedQuerys()
        {
            MethodBasedQuerys.RunMethodBasedQuerys();
            Console.WriteLine("press any key to continue.");
            Console.ReadLine();
        }

        private static void RunLinqToXml()
        {
            LinqToXML.TransformLinqToXML();
            Console.WriteLine("press any key to finish.");
            Console.ReadLine();
        }
    }
}
