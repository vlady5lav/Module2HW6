namespace ModuleHW
{
    public abstract class Audi : GermanICECars
    {
        public Audi()
        {
            Manufacturer = CarManufacturers.Audi;
            ManufacturingCountry = CarManufacturingCountries.Germany;
        }
    }
}
