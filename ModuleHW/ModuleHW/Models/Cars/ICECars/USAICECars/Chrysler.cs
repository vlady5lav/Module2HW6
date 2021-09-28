namespace ModuleHW
{
    public abstract class Chrysler : USAICECars
    {
        public Chrysler()
        {
            Manufacturer = CarManufacturers.Chrysler;
            ManufacturingCountry = CarManufacturingCountries.USA;
        }
    }
}
