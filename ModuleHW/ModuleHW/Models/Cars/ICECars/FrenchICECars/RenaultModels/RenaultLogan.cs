namespace ModuleHW
{
    public class RenaultLogan : Renault
    {
        public RenaultLogan()
        {
            Acceleration = 6.8;
            BodyType = CarBodyTypes.Sedan;
            FuelConsumption = 5.0;
            FuelTankCapacity = 55;
            FuelType = CarFuelTypes.Petrol;
            MaxSpeed = 180;
            Model = "Logan";
            Price = 966875;
            SeatsNumber = 5;
            TaxiClassType = TaxiClassTypes.Comfort;
            Weight = 1400;
        }
    }
}
