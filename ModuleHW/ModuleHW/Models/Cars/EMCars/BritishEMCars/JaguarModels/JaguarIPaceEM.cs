namespace ModuleHW
{
    public class JaguarIPaceEM : JaguarEM
    {
        public JaguarIPaceEM()
        {
            Acceleration = 4.8;
            BodyType = CarBodyTypes.SUV;
            BatteryType = CarBatteryTypes.LiIon;
            BatteryCapacity = 100;
            BatteryConsumption = 23.5;
            ChargingTime = 510.ToTimeString();
            FuelType = CarFuelTypes.Electricity;
            MaxSpeed = 200;
            Model = "IPace";
            PowerReserve = 435;
            Price = 2200000;
            SeatsNumber = 5;
            TaxiClassType = TaxiClassTypes.Business;
            Weight = 2670;
        }
    }
}
