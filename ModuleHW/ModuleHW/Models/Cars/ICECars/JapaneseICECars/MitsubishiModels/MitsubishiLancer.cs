namespace ModuleHW
{
    public class MitsubishiLancer : Mitsubishi
    {
        public MitsubishiLancer()
        {
            Acceleration = 5.8;
            BodyType = CarBodyTypes.Sedan;
            FuelConsumption = 5.0;
            FuelTankCapacity = 55;
            FuelType = CarFuelTypes.Diesel;
            MaxSpeed = 220;
            Model = "Lancer";
            Price = 1466875;
            SeatsNumber = 5;
            TaxiClassType = TaxiClassTypes.Comfort;
            Weight = 1450;
        }
    }
}
