namespace ModuleHW
{
    public abstract class EMCar : Car
    {
        public EMCar()
        {
            AutomaticTransmission = true;
            EngineType = CarEngineTypes.EM;
            FuelType = CarFuelTypes.Electricity;
        }

        public override CarBatteryTypes BatteryType { get; init; }
        public override double? BatteryCapacity { get; init; }
        public override double? BatteryConsumption { get; init; }
        public override double? PowerReserve { get; init; }
        public override string ChargingTime { get; init; }
    }
}
