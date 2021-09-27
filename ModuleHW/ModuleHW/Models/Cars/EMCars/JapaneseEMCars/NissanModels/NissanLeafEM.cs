namespace ModuleHW
{
    public class NissanLeafEM : NissanEM
    {
        public NissanLeafEM()
        {
            Acceleration = 6.8;
            BodyType = CarBodyTypes.Hatchback;
            BatteryType = CarBatteryTypes.LiIon;
            BatteryCapacity = 70;
            BatteryConsumption = 18.5;
            ChargingTime = 570.ToTimeString();
            FuelType = CarFuelTypes.Electricity;
            MaxSpeed = 165;
            Model = "Leaf";
            PowerReserve = 320;
            Price = 1100500;
            SeatsNumber = 5;
            TaxiClassType = TaxiClassTypes.Comfort;
            Weight = 1200;
        }
    }
}
