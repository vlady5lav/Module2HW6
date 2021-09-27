namespace ModuleHW
{
    public class Peugeot308 : Peugeot
    {
        public Peugeot308()
        {
            Acceleration = 6.5;
            BodyType = CarBodyTypes.Sedan;
            FuelConsumption = 5.1;
            FuelTankCapacity = 50;
            FuelType = CarFuelTypes.Diesel;
            MaxSpeed = 195;
            Model = "308";
            Price = 1466875;
            SeatsNumber = 5;
            TaxiClassType = TaxiClassTypes.Comfort;
            Weight = 1500;
        }
    }
}
