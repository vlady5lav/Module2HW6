namespace ModuleHW
{
    public abstract class Lexus : JapaneseICECars
    {
        public Lexus()
        {
            Manufacturer = CarManufacturers.Lexus;
            ManufacturingCountry = CarManufacturingCountries.Japan;
        }
    }
}
