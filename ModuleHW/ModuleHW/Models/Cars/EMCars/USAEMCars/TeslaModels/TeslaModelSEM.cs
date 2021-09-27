namespace ModuleHW
{
    public class TeslaModelSEM : TeslaEM
    {
        public TeslaModelSEM()
        {
            Acceleration = 5.5;
            BodyType = CarBodyTypes.Sedan;
            BatteryType = CarBatteryTypes.LiIon;
            BatteryCapacity = 90;
            BatteryConsumption = 22.5;
            ChargingTime = 475.ToTimeString();
            FuelType = CarFuelTypes.Electricity;
            MaxSpeed = 180;
            Model = "Model S";
            PowerReserve = 420;
            Price = 1900300;
            SeatsNumber = 5;
            TaxiClassType = TaxiClassTypes.Premium;
            Weight = 1600;
        }
    }
}
