namespace ModuleHW
{
    public abstract class ICECar : Car
    {
        public ICECar()
        {
            EngineType = CarEngineTypes.ICE;
            FuelConsumptionUnit = FuelConsumptionUnits.LP100KM;
        }

        public virtual double FuelConsumption { get; set; }
        public virtual double FuelTankCapacity { get; set; }
        public virtual FuelConsumptionUnits FuelConsumptionUnit { get; set; }
    }
}
