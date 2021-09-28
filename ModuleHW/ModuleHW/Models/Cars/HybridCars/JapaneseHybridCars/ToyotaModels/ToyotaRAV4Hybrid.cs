namespace ModuleHW
{
    public class ToyotaRAV4Hybrid : ToyotaHybrid
    {
        public ToyotaRAV4Hybrid()
        {
            Acceleration = 8.2;
            BodyType = CarBodyTypes.Crossover;
            BatteryType = CarBatteryTypes.LiIon;
            BatteryCapacity = 95;
            BatteryConsumption = 23.5;
            FuelConsumption = 4.9;
            FuelTankCapacity = 55;
            FuelType = CarFuelTypes.Petrol;
            MaxSpeed = 180;
            Model = "RAV4 Hybrid";
            PowerReserve = 435;
            Price = 1150000;
            SeatsNumber = 5;
            TaxiClassType = TaxiClassTypes.Premium;
            Weight = 1800;
        }
    }
}
