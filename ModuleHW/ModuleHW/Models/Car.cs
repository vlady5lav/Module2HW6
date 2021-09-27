namespace ModuleHW
{
    public abstract class Car
    {
        public Car()
        {
        }

        public virtual CarManufacturers Manufacturer { get; set; }
        public virtual CarManufacturingCountries ManufacturingCountry { get; set; }
        public virtual string Model { get; set; }
        public virtual CarBodyTypes BodyType { get; set; }
        public virtual CarEngineTypes EngineType { get; set; }
        public virtual CarFuelTypes FuelType { get; set; }
        public virtual double FuelConsumption { get; set; }
        public virtual FuelConsumptionUnits FuelConsumptionUnit { get; set; }
        public virtual CarSegments Segment { get; set; }
        public virtual int Year { get; set; }
        public virtual double Mileage { get; set; }
        public virtual CarColors Color { get; set; }
        public virtual double MaxSpeed { get; set; }
        public virtual SpeedUnits SpeedUnit { get; set; }
        public virtual double Acceleration { get; set; }
        public virtual double Weight { get; set; }
        public virtual WeightUnits WeightUnit { get; set; }
        public virtual double Price { get; set; }
        public virtual CurrencyUnits CurrencyUnit { get; set; }
        public virtual int SeatsNumber { get; set; }
        public virtual TaxiClassTypes TaxiClassType { get; set; }
        public virtual bool AutomaticTransmission { get; set; }
        public virtual bool AirConditioning { get; set; }
    }
}
