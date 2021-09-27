namespace ModuleHW
{
    public abstract class ICECar : Car
    {
        public ICECar()
        {
            EngineType = CarEngineTypes.ICE;
            FuelConsumptionUnit = FuelConsumptionUnits.LP100KM;
        }

        public override double? FuelConsumption { get; set; }
        public override double? FuelTankCapacity { get; init; }
        public override FuelConsumptionUnits FuelConsumptionUnit { get; set; }
    }
}
