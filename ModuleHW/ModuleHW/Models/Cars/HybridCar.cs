namespace ModuleHW
{
    public abstract class HybridCar : Car
    {
        public HybridCar()
        {
            AutomaticTransmission = true;
            EngineType = CarEngineTypes.Hybrid;
            FuelConsumptionUnit = FuelConsumptionUnits.LP100KM;
        }

        public virtual CarBatteryTypes BatteryType { get; set; }
        public virtual double BatteryCapacity { get; set; }
        public virtual double BatteryConsumption { get; set; }
        public virtual double PowerReserve { get; set; }
        public virtual double FuelTankCapacity { get; set; }
    }
}
