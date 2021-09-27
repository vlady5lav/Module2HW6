namespace ModuleHW
{
    public class SkodaSuperb : Skoda
    {
        public SkodaSuperb()
        {
            Acceleration = 6.0;
            BodyType = CarBodyTypes.Sedan;
            FuelConsumption = 5.0;
            FuelTankCapacity = 50;
            FuelType = CarFuelTypes.Petrol;
            MaxSpeed = 200;
            Model = "Superb";
            Price = 1266875;
            SeatsNumber = 5;
            TaxiClassType = TaxiClassTypes.Comfort;
            Weight = 1500;
        }
    }
}
