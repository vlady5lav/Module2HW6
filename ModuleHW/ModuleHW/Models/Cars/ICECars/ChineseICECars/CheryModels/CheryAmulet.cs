namespace ModuleHW
{
    public class CheryAmulet : Chery
    {
        public CheryAmulet()
        {
            Acceleration = 7.9;
            BodyType = CarBodyTypes.Sedan;
            FuelConsumption = 5.2;
            FuelTankCapacity = 50;
            FuelType = CarFuelTypes.Petrol;
            MaxSpeed = 160;
            Model = "Amulet";
            Price = 530000;
            SeatsNumber = 5;
            TaxiClassType = TaxiClassTypes.Comfort;
            Weight = 1400;
        }
    }
}
