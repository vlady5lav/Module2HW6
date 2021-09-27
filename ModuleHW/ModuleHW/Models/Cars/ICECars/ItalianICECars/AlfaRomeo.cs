namespace ModuleHW
{
    public abstract class AlfaRomeo : ItalianICECars
    {
        public AlfaRomeo()
        {
            Manufacturer = CarManufacturers.AlfaRomeo;
            ManufacturingCountry = CarManufacturingCountries.Italy;
        }
    }
}
