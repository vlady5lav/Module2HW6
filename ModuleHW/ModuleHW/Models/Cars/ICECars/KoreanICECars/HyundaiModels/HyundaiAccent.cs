namespace ModuleHW
{
    public class HyundaiAccent : Hyundai
    {
        public HyundaiAccent()
        {
            Acceleration = 6.5;
            BodyType = CarBodyTypes.Sedan;
            FuelConsumption = 4.9;
            FuelTankCapacity = 55;
            FuelType = CarFuelTypes.Petrol;
            MaxSpeed = 185;
            Model = "Accent";
            Price = 540000;
            SeatsNumber = 5;
            TaxiClassType = TaxiClassTypes.Comfort;
            Weight = 1350;
        }
    }
}
