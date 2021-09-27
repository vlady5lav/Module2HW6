namespace ModuleHW
{
    public class GeelyEmgrand : Geely
    {
        public GeelyEmgrand()
        {
            Acceleration = 8.8;
            BodyType = CarBodyTypes.Sedan;
            FuelConsumption = 6.0;
            FuelTankCapacity = 50;
            FuelType = CarFuelTypes.Petrol;
            MaxSpeed = 170;
            Model = "Emgrand";
            Price = 420000;
            SeatsNumber = 5;
            TaxiClassType = TaxiClassTypes.Economy;
            Weight = 1300;
        }
    }
}
