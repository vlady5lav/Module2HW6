namespace ModuleHW
{
    public abstract class Toyota : JapaneseICECars
    {
        public Toyota()
        {
            Manufacturer = CarManufacturers.Toyota;
            ManufacturingCountry = CarManufacturingCountries.Japan;
        }
    }
}
