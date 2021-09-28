namespace ModuleHW
{
    public abstract class Porsche : GermanICECars
    {
        public Porsche()
        {
            Manufacturer = CarManufacturers.Porsche;
            ManufacturingCountry = CarManufacturingCountries.Germany;
        }
    }
}
