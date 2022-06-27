using System.Collections.Generic;

namespace MainModel
{
    public class AgencyApartmentConnection : IModelElement
    {
        public int AgencyId { get; init; }
        public int ApartmentId { get; init; }
        public int ApartmentPrice { get; init; }

        public Dictionary<string, string> GetProperties()
        {
            Dictionary<string, string> properties = new();
            
            properties.Add("agencyId", AgencyId.ToString());
            properties.Add("apartmentId", ApartmentId.ToString());
            properties.Add("apartmentPrice", ApartmentPrice.ToString());
            
            return properties;
        }
    }
}
