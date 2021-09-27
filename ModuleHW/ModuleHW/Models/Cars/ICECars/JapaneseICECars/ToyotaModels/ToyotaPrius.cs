namespace ModuleHW
{
    public class ToyotaPrius : Toyota
    {
        public ToyotaPrius()
        {
            Acceleration = 6.9;
            BodyType = CarBodyTypes.Hatchback;
            FuelConsumption = 5.5;
            FuelTankCapacity = 55;
            FuelType = CarFuelTypes.Petrol;
            MaxSpeed = 190;
            Model = "Prius";
            Price = 1266875;
            SeatsNumber = 5;
            TaxiClassType = TaxiClassTypes.Comfort;
            Weight = 1600;
        }
    }
}
