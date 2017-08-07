using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToolkit.models
{
    public class Hometown
    {
        public string City { get; set; }
        public string State { get; set; }

        public override bool Equals(object obj)
        {
            Hometown actual = obj as Hometown;
            return actual.City.Equals(this.City) && actual.State.Equals(this.State);
        }
    }
}
