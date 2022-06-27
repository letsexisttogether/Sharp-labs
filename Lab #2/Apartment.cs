using System.Collections.Generic;

namespace MainModel
{
    public class Apartment : IModelElement
    {
        public int Id { get; init; }
        public string Address { get; init; } = string.Empty;
        public int Floor { get; init; }
        public float Square { get; init; }

        public Dictionary<string, string> GetProperties()
        {
            Dictionary<string, string> properties = new();
            
            properties.Add("id", Id.ToString());
            properties.Add("address", Address);
            properties.Add("floor", Floor.ToString());
            properties.Add("square", Square.ToString());
            
            return properties;
        }
        public override string ToString()
        {
            return $"Адреса квартири: {Address} Поверх: {Floor}  Площа квартири: {Square}";
        }
    }
}
