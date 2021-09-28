namespace ModuleHW
{
    public class GeelyMK : Geely
    {
        public GeelyMK()
        {
            Acceleration = 9.0;
            BodyType = CarBodyTypes.Sedan;
            FuelConsumption = 5.5;
            FuelTankCapacity = 50;
            FuelType = CarFuelTypes.Petrol;
            MaxSpeed = 160;
            Model = "MK";
            Price = 400000;
            SeatsNumber = 5;
            TaxiClassType = TaxiClassTypes.Economy;
            Weight = 1200;
        }
    }
}
