namespace ModuleHW
{
    public abstract class Fiat : ItalianICECars
    {
        public Fiat()
        {
            Manufacturer = CarManufacturers.Fiat;
            ManufacturingCountry = CarManufacturingCountries.Italy;
        }
    }
}
