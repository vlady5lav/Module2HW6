namespace ModuleHW
{
    public class JaguarXE : Jaguar
    {
        public JaguarXE()
        {
            Acceleration = 5.9;
            BodyType = CarBodyTypes.Sedan;
            FuelConsumption = 5.1;
            FuelTankCapacity = 50;
            FuelType = CarFuelTypes.Petrol;
            MaxSpeed = 210;
            Model = "XE";
            Price = 1306875;
            SeatsNumber = 5;
            TaxiClassType = TaxiClassTypes.Premium;
            Weight = 1670;
        }
    }
}
