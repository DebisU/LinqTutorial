
namespace LinqToolkit.models
{
    public class Hometown2 : Hometown
    {
        public string CityCode { get; set; }

        public override bool Equals(object obj)
        {
            Hometown2 actual = obj as Hometown2;
            return base.Equals(obj) && actual.CityCode.Equals(this.CityCode);
        }
    }
}
