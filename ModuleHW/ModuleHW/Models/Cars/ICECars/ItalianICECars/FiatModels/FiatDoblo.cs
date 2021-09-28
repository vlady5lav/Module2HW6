namespace ModuleHW
{
    public class FiatDoblo : Fiat
    {
        public FiatDoblo()
        {
            Acceleration = 8.5;
            BodyType = CarBodyTypes.Minivan;
            FuelConsumption = 6.3;
            FuelTankCapacity = 65;
            FuelType = CarFuelTypes.Petrol;
            MaxSpeed = 165;
            Model = "Doblo";
            Price = 380475;
            SeatsNumber = 5;
            TaxiClassType = TaxiClassTypes.Minivan;
            Weight = 1500;
        }
    }
}
