namespace ModuleHW
{
    public abstract class MercedesBenz : GermanICECars
    {
        public MercedesBenz()
        {
            Manufacturer = CarManufacturers.MercedesBenz;
            ManufacturingCountry = CarManufacturingCountries.Germany;
        }
    }
}
