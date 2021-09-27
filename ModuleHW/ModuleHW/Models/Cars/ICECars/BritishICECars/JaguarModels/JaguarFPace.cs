namespace ModuleHW
{
    public class JaguarFPace : Jaguar
    {
        public JaguarFPace()
        {
            Acceleration = 5.0;
            BodyType = CarBodyTypes.SUV;
            FuelConsumption = 5.0;
            FuelTankCapacity = 50;
            FuelType = CarFuelTypes.Diesel;
            MaxSpeed = 220;
            Model = "FPace";
            Price = 1966875;
            SeatsNumber = 5;
            TaxiClassType = TaxiClassTypes.Business;
            Weight = 2470;
        }
    }
}
