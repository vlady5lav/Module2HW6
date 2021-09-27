namespace ModuleHW
{
    public class JaguarEPace : Jaguar
    {
        public JaguarEPace()
        {
            Acceleration = 5.2;
            BodyType = CarBodyTypes.SUV;
            FuelConsumption = 5.2;
            FuelTankCapacity = 55;
            FuelType = CarFuelTypes.Diesel;
            MaxSpeed = 200;
            Model = "EPace";
            Price = 1766875;
            SeatsNumber = 5;
            TaxiClassType = TaxiClassTypes.Business;
            Weight = 2350;
        }
    }
}
