namespace ModuleHW
{
    public abstract class Pagani : ItalianICECars
    {
        public Pagani()
        {
            Manufacturer = CarManufacturers.Pagani;
            ManufacturingCountry = CarManufacturingCountries.Italy;
        }
    }
}
