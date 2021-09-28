namespace ModuleHW
{
    public abstract class Geely : ChineseICECars
    {
        public Geely()
        {
            Manufacturer = CarManufacturers.Geely;
            ManufacturingCountry = CarManufacturingCountries.China;
        }
    }
}
