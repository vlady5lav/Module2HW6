using System;
using System.Text;

namespace ModuleHW
{
    public abstract class Car
    {
        private readonly Random _random;
        private StringBuilder _sb;

        public Car()
        {
            _random = RandomHelper.Random;

            AirConditioning = _random.NextBool(60);
            Color = (CarColors)_random.Next(11);
            CurrencyUnit = CurrencyUnits.UAH;
            Mileage = Math.Round(_random.NextDoubleValue(1000, 10000), 0);
            MileageUnit = MileageUnits.KM;
            SpeedUnit = SpeedUnits.KMPH;
            WeightUnit = WeightUnits.KG;
            Year = _random.Next(2015, 2021);
        }

        public virtual bool AirConditioning { get; init; }
        public virtual bool AutomaticTransmission { get; init; }
        public virtual CarBatteryTypes? BatteryType { get; init; }
        public virtual CarBodyTypes? BodyType { get; init; }
        public virtual CarColors? Color { get; init; }
        public virtual CarEngineTypes? EngineType { get; init; }
        public virtual CarFuelTypes? FuelType { get; init; }
        public virtual CarManufacturers? Manufacturer { get; init; }
        public virtual CarManufacturingCountries? ManufacturingCountry { get; init; }
        public virtual CarSegments? Segment { get; set; }
        public virtual CurrencyUnits? CurrencyUnit { get; set; }
        public virtual double? Acceleration { get; init; }
        public virtual double? BatteryCapacity { get; init; }
        public virtual double? BatteryConsumption { get; init; }
        public virtual double? FuelConsumption { get; set; }
        public virtual double? FuelTankCapacity { get; init; }
        public virtual double? Mileage { get; set; }
        public virtual double? PowerReserve { get; init; }
        public virtual double? Price { get; set; }
        public virtual double? Weight { get; set; }
        public virtual FuelConsumptionUnits? FuelConsumptionUnit { get; set; }
        public virtual int? MaxSpeed { get; set; }
        public virtual int? SeatsNumber { get; init; }
        public virtual int? Year { get; init; }
        public virtual MileageUnits? MileageUnit { get; set; }
        public virtual SpeedUnits? SpeedUnit { get; set; }
        public virtual string ChargingTime { get; init; }
        public virtual string Model { get; init; }
        public virtual TaxiClassTypes? TaxiClassType { get; init; }
        public virtual WeightUnits? WeightUnit { get; set; }

        public override string ToString()
        {
            _sb = new StringBuilder();

            _sb.Append($"{Manufacturer} {Model}{Environment.NewLine}Year: {Year}, Color: {Color}, Mileage: {Mileage} {MileageUnit}, Price: {Price} {CurrencyUnit},{Environment.NewLine}" +
                $"MaxSpeed: {MaxSpeed} {SpeedUnit}, Weight: {Weight} {WeightUnit}");

            if (AutomaticTransmission == true)
            {
                _sb.Append(", Automatic transmission");
            }
            else
            {
                _sb.Append(", Manual Transmission");
            }

            if (AirConditioning == true)
            {
                _sb.AppendLine(", with Air Conditioning");
            }
            else
            {
                _sb.AppendLine(", without Air Conditioning");
            }

            return _sb.ToString();
        }
    }
}
