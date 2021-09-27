using System;

namespace ModuleHW
{
    public abstract class ICECar : Car
    {
        private readonly Random _random;

        public ICECar()
        {
            _random = RandomHelper.Random;

            AutomaticTransmission = _random.NextBool(60);
            EngineType = CarEngineTypes.ICE;
            FuelConsumptionUnit = FuelConsumptionUnits.LP100KM;
        }

        public override bool AutomaticTransmission { get; init; }
        public override double? FuelConsumption { get; set; }
        public override double? FuelTankCapacity { get; init; }
        public override FuelConsumptionUnits? FuelConsumptionUnit { get; set; }
    }
}
