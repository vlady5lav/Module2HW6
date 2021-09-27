namespace ModuleHW
{
    public abstract class Lancia : ItalianICECars
    {
        public Lancia()
        {
            Manufacturer = CarManufacturers.Lancia;
            ManufacturingCountry = CarManufacturingCountries.Italy;
        }
    }
}
