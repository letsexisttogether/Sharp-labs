namespace Lab9.MainClasses
{
    public class AgencyAppartmentConnection
    {
        public int AgencyId { get; init; }
        public int ApartmentId { get; init; }
        public int ApartmentPrice { get; init; }
        
        public AgencyAppartmentConnection()
        {
            AgencyId = 0;
            ApartmentId = 0;
            ApartmentPrice = 0;
        }
    }
}