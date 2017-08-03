using LinqToolkit.Lessons._3._XML;
using System;

namespace LinqToolkit.Main.Sections
{
    class XML
    {
        public static void RunXmlExpressions()
        {
            LinqToXMLExport();
        }

        private static void LinqToXMLExport()
        {
            Print();
            Print("Linq to XML: ");
            LinqToXML.TransformLinqToXML();
        }

        private static void Print(string str = "")
        {
            Console.WriteLine(str);
        }
    }
}
