namespace ModuleHW
{
    public class FordFocus : Ford
    {
        public FordFocus()
        {
            Acceleration = 6.7;
            BodyType = CarBodyTypes.Sedan;
            FuelConsumption = 5.0;
            FuelTankCapacity = 55;
            FuelType = CarFuelTypes.Petrol;
            MaxSpeed = 170;
            Model = "Focus";
            Price = 450000;
            SeatsNumber = 5;
            TaxiClassType = TaxiClassTypes.Comfort;
            Weight = 1200;
        }
    }
}
