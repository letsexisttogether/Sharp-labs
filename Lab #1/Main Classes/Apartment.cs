namespace Lab9.MainClasses
{
    public class Apartment
    {
        public int ApartmentId { get; init; }
        public string ApartmentAddress { get; init; }
        public int ApartmentFloor { get; init; }
        public double ApartmentSquare { get; init; }

        public Apartment()
        {
            ApartmentId = 0;
            ApartmentAddress = string.Empty;
            ApartmentFloor = 0;
            ApartmentSquare = 0d;
        }

        public override string ToString()
        {
            return $"ID: {ApartmentId}, Адреса: {ApartmentAddress} " +
                $"Поверх квартири: {ApartmentFloor}, Площа: {ApartmentSquare}";
        }
    }
}
