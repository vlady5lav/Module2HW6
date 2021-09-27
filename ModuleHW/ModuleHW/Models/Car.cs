namespace ModuleHW
{
    public abstract class Car
    {
        public Car()
        {
        }

        public virtual bool AirConditioning { get; set; } // because i need to set up it randomly
        public virtual bool AutomaticTransmission { get; set; } // because i need to set up it randomly
        public virtual CarBatteryTypes BatteryType { get; init; }
        public virtual CarBodyTypes BodyType { get; init; }
        public virtual CarColors Color { get; set; } // because i need to set up it randomly
        public virtual CarEngineTypes EngineType { get; init; }
        public virtual CarFuelTypes FuelType { get; init; }
        public virtual CarManufacturers Manufacturer { get; init; }
        public virtual CarManufacturingCountries ManufacturingCountry { get; init; }
        public virtual CarSegments Segment { get; set; }
        public virtual CurrencyUnits CurrencyUnit { get; set; } // because i need to convert units
        public virtual double? Acceleration { get; init; }
        public virtual double? BatteryCapacity { get; init; }
        public virtual double? BatteryConsumption { get; init; }
        public virtual double? FuelConsumption { get; set; } // because i need to convert units
        public virtual double? FuelTankCapacity { get; init; }
        public virtual double? Mileage { get; set; } // because i need to set up it randomly
        public virtual double? PowerReserve { get; init; }
        public virtual double? Price { get; set; } // because i need to convert units
        public virtual double? Weight { get; set; } // because i need to convert units
        public virtual FuelConsumptionUnits FuelConsumptionUnit { get; set; } // because i need to convert units
        public virtual int? MaxSpeed { get; set; } // because i need to convert units
        public virtual int? SeatsNumber { get; init; }
        public virtual int? Year { get; set; } // because i need to set up it randomly
        public virtual SpeedUnits SpeedUnit { get; set; } // because i need to convert units
        public virtual string ChargingTime { get; init; }
        public virtual string Model { get; init; }
        public virtual TaxiClassTypes TaxiClassType { get; init; }
        public virtual WeightUnits WeightUnit { get; set; } // because i need to convert units
    }
}
