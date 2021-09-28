namespace ModuleHW
{
    public abstract class Volkswagen : GermanICECars
    {
        public Volkswagen()
        {
            Manufacturer = CarManufacturers.Volkswagen;
            ManufacturingCountry = CarManufacturingCountries.Germany;
        }
    }
}
