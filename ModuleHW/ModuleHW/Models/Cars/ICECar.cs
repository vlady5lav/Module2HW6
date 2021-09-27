namespace ModuleHW
{
    public abstract class ICECar : Car
    {
        public ICECar()
        {
            EngineType = CarEngineTypes.ICE;
            FuelConsumptionUnit = FuelConsumptionUnits.LP100KM;
        }

        public virtual double FuelTankCapacity { get; set; }
    }
}
