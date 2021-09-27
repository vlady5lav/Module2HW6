namespace ModuleHW
{
    public abstract class Nissan : JapaneseICECars
    {
        public Nissan()
        {
            Manufacturer = CarManufacturers.Nissan;
            ManufacturingCountry = CarManufacturingCountries.Japan;
        }
    }
}
