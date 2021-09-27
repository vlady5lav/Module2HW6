namespace ModuleHW
{
    public abstract class Jeep : USAICECars
    {
        public Jeep()
        {
            Manufacturer = CarManufacturers.Jeep;
            ManufacturingCountry = CarManufacturingCountries.USA;
        }
    }
}
