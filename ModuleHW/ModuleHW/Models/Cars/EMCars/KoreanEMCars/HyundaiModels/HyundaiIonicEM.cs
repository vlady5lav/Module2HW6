namespace ModuleHW
{
    public class HyundaiIonicEM : HyundaiEM
    {
        public HyundaiIonicEM()
        {
            Acceleration = 6.0;
            BodyType = CarBodyTypes.Hatchback;
            BatteryType = CarBatteryTypes.LiIon;
            BatteryCapacity = 85;
            BatteryConsumption = 21.5;
            ChargingTime = 500.ToTimeString();
            FuelType = CarFuelTypes.Electricity;
            MaxSpeed = 170;
            Model = "Ionic";
            PowerReserve = 400;
            Price = 1400300;
            SeatsNumber = 5;
            TaxiClassType = TaxiClassTypes.Premium;
            Weight = 1500;
        }
    }
}
