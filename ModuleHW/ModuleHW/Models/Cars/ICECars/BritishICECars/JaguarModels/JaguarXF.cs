namespace ModuleHW
{
    public class JaguarXF : Jaguar
    {
        public JaguarXF()
        {
            Acceleration = 5.7;
            BodyType = CarBodyTypes.Sedan;
            FuelConsumption = 5.0;
            FuelTankCapacity = 50;
            FuelType = CarFuelTypes.Diesel;
            MaxSpeed = 220;
            Model = "XF";
            Price = 1766875;
            SeatsNumber = 5;
            TaxiClassType = TaxiClassTypes.Premium;
            Weight = 1570;
        }
    }
}
