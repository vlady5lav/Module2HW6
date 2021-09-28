namespace ModuleHW
{
    public class PorscheTaycanEM : PorscheEM
    {
        public PorscheTaycanEM()
        {
            Acceleration = 3.2;
            BodyType = CarBodyTypes.Sport;
            BatteryType = CarBatteryTypes.LiIon;
            BatteryCapacity = 93.4;
            BatteryConsumption = 26.0;
            ChargingTime = 630.ToTimeString();
            FuelType = CarFuelTypes.Electricity;
            MaxSpeed = 260;
            Model = "Taycan Turbo";
            PowerReserve = 420;
            Price = 4300000;
            SeatsNumber = 5;
            TaxiClassType = TaxiClassTypes.Business;
            Weight = 2200;
        }
    }
}
