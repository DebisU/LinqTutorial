using LinqToolkit.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToolkit.Lessons._3._XML
{
    class LinqToXML
    {
        public static XElement TransformLinqToXML()
        {
            List<Employee> employees = ObjectFactory.GetListOfEmployees();
            XElement xmlEmployees = new XElement("Root", from e in employees
                                                    select new XElement("Employee", new XElement("FirstName", e.FirstName),
                                                    new XElement("LastName", e.LastName)));
            return xmlEmployees;
        }

    }
}
