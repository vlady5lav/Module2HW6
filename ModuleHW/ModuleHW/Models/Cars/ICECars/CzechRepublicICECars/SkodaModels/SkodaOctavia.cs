namespace ModuleHW
{
    public class SkodaOctavia : Skoda
    {
        public SkodaOctavia()
        {
            Acceleration = 6.2;
            BodyType = CarBodyTypes.Sedan;
            FuelConsumption = 5.2;
            FuelTankCapacity = 50;
            FuelType = CarFuelTypes.Petrol;
            MaxSpeed = 190;
            Model = "Octavia";
            Price = 1066875;
            SeatsNumber = 5;
            TaxiClassType = TaxiClassTypes.Comfort;
            Weight = 1400;
        }
    }
}
