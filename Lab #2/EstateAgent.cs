using System.Collections.Generic;   

namespace MainModel
{
    public class EstateAgent : IModelElement
    {
        public int Id { get; init; }
        public int AgencyId { get; init; }
        public string Name { get; init; } = string.Empty;
        public string MobileNumber { get; init; } = string.Empty;

        public Dictionary<string, string> GetProperties()
        {
            Dictionary<string, string> properties = new();
            
            properties.Add("id", Id.ToString());
            properties.Add("agencyId", AgencyId.ToString());
            properties.Add("name", Name);
            properties.Add("mobileNumber", MobileNumber);

            return properties;
        }
        public override string ToString()
        {
            return $"Ім'я: {Name} Номер телефону: {MobileNumber}";
        }
    }
}
