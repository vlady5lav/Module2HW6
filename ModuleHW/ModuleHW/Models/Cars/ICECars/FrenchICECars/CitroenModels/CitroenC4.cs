namespace ModuleHW
{
    public class CitroenC4 : Citroen
    {
        public CitroenC4()
        {
            Acceleration = 5.7;
            BodyType = CarBodyTypes.Sedan;
            FuelConsumption = 5.2;
            FuelTankCapacity = 52;
            FuelType = CarFuelTypes.Petrol;
            MaxSpeed = 200;
            Model = "C4";
            Price = 1366875;
            SeatsNumber = 5;
            TaxiClassType = TaxiClassTypes.Comfort;
            Weight = 1500;
        }
    }
}
