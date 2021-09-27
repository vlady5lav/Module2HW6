namespace ModuleHW
{
    public class KiaOptima : Kia
    {
        public KiaOptima()
        {
            Acceleration = 6.9;
            BodyType = CarBodyTypes.Sedan;
            FuelConsumption = 5.0;
            FuelTankCapacity = 55;
            FuelType = CarFuelTypes.Petrol;
            MaxSpeed = 180;
            Model = "Optima";
            Price = 520000;
            SeatsNumber = 5;
            TaxiClassType = TaxiClassTypes.Comfort;
            Weight = 1400;
        }
    }
}
