namespace ModuleHW
{
    public abstract class Ferrari : ItalianICECars
    {
        public Ferrari()
        {
            Manufacturer = CarManufacturers.Ferrari;
            ManufacturingCountry = CarManufacturingCountries.Italy;
        }
    }
}
