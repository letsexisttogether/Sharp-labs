using System.Collections.Generic;

namespace MainModel
{
    public class Agency : IModelElement
    {
        public int Id { get; init; }
        public string Title { get; init; } = string.Empty;
        public string Address { get; init; } = string.Empty;

        public Dictionary<string, string> GetProperties()
        {
            Dictionary<string, string> properties = new();

            properties.Add("id", Id.ToString());
            properties.Add("title", Title);
            properties.Add("address", Address);

            return properties;
        }

        public override string ToString()
        {
            return $"Назва: {Title} Адреса агенства: {Address}";
        }
    }
}
