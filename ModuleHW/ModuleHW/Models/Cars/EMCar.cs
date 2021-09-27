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

        public virtual CarBatteryTypes BatteryType { get; set; }
        public virtual double BatteryCapacity { get; set; }
        public virtual double BatteryConsumption { get; set; }
        public virtual string ChargingTime { get; set; }
        public virtual double PowerReserve { get; set; }
    }
}
