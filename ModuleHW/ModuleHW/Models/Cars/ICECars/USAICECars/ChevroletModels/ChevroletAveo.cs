namespace ModuleHW
{
    public class ChevroletAveo : Chevrolet
    {
        public ChevroletAveo()
        {
            Acceleration = 7.5;
            BodyType = CarBodyTypes.Sedan;
            FuelConsumption = 5.3;
            FuelTankCapacity = 50;
            FuelType = CarFuelTypes.Petrol;
            MaxSpeed = 160;
            Model = "Aveo";
            Price = 150847;
            SeatsNumber = 5;
            TaxiClassType = TaxiClassTypes.Economy;
            Weight = 1400;
        }
    }
}
