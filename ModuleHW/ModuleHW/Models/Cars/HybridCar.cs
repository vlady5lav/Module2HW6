namespace ModuleHW
{
    public abstract class HybridCar : Car
    {
        public HybridCar()
        {
            AutomaticTransmission = true;
            EngineType = CarEngineTypes.Hybrid;
            FuelConsumptionUnit = FuelConsumptionUnits.LP100KM;
            FuelType = CarFuelTypes.Hybrid;
        }

        public override CarBatteryTypes? BatteryType { get; init; }
        public override double? BatteryCapacity { get; init; }
        public override double? BatteryConsumption { get; init; }
        public override double? FuelConsumption { get; set; }
        public override double? FuelTankCapacity { get; init; }
        public override double? PowerReserve { get; init; }
        public override FuelConsumptionUnits? FuelConsumptionUnit { get; set; }
    }
}
